using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Game_Of_Life.GameOfLife;

namespace Game_Of_Life.Simulation {
    public class GameOfLifeLogic {
        private static int[,] cacheBoard;       // Copy of simulationBoard
        public static bool simulationState;     // State of simulation
        public static bool verboseOutput = false;
        public static bool verboseOutput2 = true;
        public static bool drawGrid = false;

        public static int generation;           // Current generation
        public static int cellMutations;        // Cell update count
        public static int cellDeaths;
        public static int cellBirths;

        /// <summary>
        /// Processes the rules of game of life for a target cell.
        /// </summary>
        /// <param name="x">X coordinate of target cell.</param>
        /// <param name="y">Y coordinate of target cell.</param>
        /// <returns>True = processed rules succesfully
        /// False = x/y coordinate under-, or overflow.</returns>
        private static bool processGameRuleSpecific(int x, int y) {
            int x_length = GameOfLife.simulationBoard.GetLength(0);
            int y_length = GameOfLife.simulationBoard.GetLength(1);
                        
            // Create backup of simulation board
            cacheBoard = simulationBoard;

            // Check if either X or Y are out of boudns
            if (x > x_length || y > y_length) {
                return false;
            }

            // Save cell state
            int cellState = GameOfLife.simulationBoard[x, y];
            if (cellState > 1) {    // Handle invalid cell state
                Console.WriteLine("[!] Cell at {0}/{1} has invalid state: {2}.", x + 1, y + 1, cellState);
                cellState = 0;
            }

            // Get neighboring cells
            int aliveCells = 0;
            int deadCells = 0;

            // ToDo: Fix detection

            // General rule for every check: out of bounds array indexes will be treated as dead cells
            // Iterate X
            for (var a = -1; a < 2; a++) {
                var xC = x + a;
                
                // OOB checks
                if (!(xC < 0 || xC >= x_length)) { 
                    // Iterate Y
                    for (var b = -1; b < 2; b++) {
                        var yC = y + b;

                        // OOB checks
                        if (!(yC < 0 || yC >= y_length)) {
                            var cState = GameOfLife.simulationBoard[xC, yC];

                            // Y is not out of bounds, get cellState
                            // > Skip check if Y & X == 0, as this would be the cell the whole neighbor check is based on
                            if (b == 0 && a == 0) {
                                if (verboseOutput2) {
                                    if (cState == 1) {
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    } else {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                    }

                                    Console.Write("X");
                                    Console.ResetColor();
                                }

                            } else {

                                if (cState == 1)
                                    aliveCells += 1;

                                if (verboseOutput2)
                                    Console.Write(cState);
                            }
                        }
                    }
                }
                Console.WriteLine(" ");
            }

            // Compute dead cells
            deadCells += 8 - aliveCells;

            /*if (verboseOutput) {
                Console.WriteLine("[i] Checks ({0}) concluded for cell {1}/{2}.", i, x + 1, y + 1);
                Console.WriteLine("Press any key to advance...");
                var thing = Console.ReadKey();
            }*/

            // Verbose output with padding
            if (verboseOutput) {
                Console.Write("[i] Cell (");
                    if (x + 1 < 10) { Console.Write("0{0}/", x + 1); }
                    else { Console.Write("{0}/", x + 1); }

                    if (y + 1 < 10) { Console.Write("0{0} ", y + 1); }
                    else { Console.Write("{0} ", y + 1); }

                Console.Write(", state '{0}'): Alive: {1}, Dead: {2}. Verdict: ", cellState, aliveCells, deadCells);
            }
            
            // Any live cell with less than two cells dies, as if by underpopulation
            if (cellState == 1 && aliveCells < 2) {
                cacheBoard[x, y] = 0;

                if (verboseOutput) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Death (starvation)");
                    Console.ResetColor();
                }

                cellDeaths++;
            }
            
            /*// Any live cell with two or three live neighbours lives on to the next generation.
            else if (cellState == 1 && (aliveCells == 2 || aliveCells == 3)) {
                cacheBoard[x, y] = 1;

                if (verboseOutput) {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Life  (unchanged)");
                    Console.ResetColor();
                }
            }*/
            
            // Any live cell with more than three live neighbours dies, as if by overpopulation.
            else if (cellState == 1 && aliveCells > 3) {
                cacheBoard[x, y] = 0;
                
                if (verboseOutput) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Death (overpopulation)");
                    Console.ResetColor();
                }

                cellDeaths++;
            }
            
            // Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
            else if (cellState == 0 && aliveCells == 3) {
                cacheBoard[x, y] = 1;
                
                if (verboseOutput) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Life  (birth)");
                    Console.ResetColor();
                }
                
                cellBirths++;
            }

            // Anything else
            else {
                if (verboseOutput) {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Unchanged");
                    Console.ResetColor();
                }
            }

            cellMutations += 1;
            return true;
        }

        /// <summary>
        /// Update simulation board according to GoL's rules.
        /// </summary>
        public static void processGameRule() {
            int x = GameOfLife.simulationBoard.GetLength(0);
            int y = GameOfLife.simulationBoard.GetLength(1);

            for (int a = 0; a < x; a++) {
                for (int b = 0; b < y; b++) {
                    //Console.WriteLine("a,b = {0},{1}", a, b);
                    processGameRuleSpecific(a, b);
                }
            }

            GameOfLifeLogic.generation++;

            // Apply new board state
            updateBoard();
        }

        public static void updateBoard() {
            GameOfLife.simulationBoard = cacheBoard;
        }
    }
}
