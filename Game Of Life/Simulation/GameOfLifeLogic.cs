﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Game_Of_Life.GameOfLife;

namespace Game_Of_Life.Simulation {
    public class GameOfLifeLogic {
        private static int[,] cacheBoard;       // Copy of simulationBoard
        public static bool simulationState;     // State of simulation
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
            int neighborCellState;
            byte aliveCells = 0;
            byte deadCells = 0;

            // General rule for every check: out of bounds array indexes will be treated as dead cells
            // Iterate X
            for (var a = -1; a < 2; a++) {
                var xC = x + a;
                //Console.WriteLine("xC at: {0}", xC);
                
                // OOB checks
                // > Always increment deadCells by 3 as the whole row is out of bounds
                if (xC < 0 || xC >= x_length) { 
                    deadCells += 3;
                } else {
                    // Iterate Y
                    for (var b = -1; b < 2; b++) {
                        var yC = y + b;
                        //Console.WriteLine("yC at: {0}", yC);
                        
                        // OOB checks
                        if (yC < 0 || yC >= y_length) {
                            deadCells++;
                        }

                        // Y is not out of bounds, get cellState
                        // > Skip check if Y & X == 0, as this would be the cell the whole neighbor check is based on
                        else if (a != 0 && b != 0) {
                            neighborCellState = GameOfLife.simulationBoard[xC, yC];
                            if (neighborCellState == 0) { deadCells += 1; }
                            else { aliveCells += 1; }
                        }
                    }
                }
            }

            // Game rules
            // Any live cell with fewer than two live neighbours dies, as if by underpopulation.
            bool canContinue = true;
            bool output = false;

            // Verbose output with padding
            if (output) {
                Console.Write("[i] Cell (");
                    if (x + 1 < 10) { Console.Write("0{0}/", x + 1); }
                    else { Console.Write("{0}/", x + 1); }

                    if (y + 1 < 10) { Console.Write("0{0} ", y + 1); }
                    else { Console.Write("{0} ", y + 1); }

                Console.Write(", state '{0}'): Alive: {1}, Dead: {2}. Verdict: ", cellState, aliveCells, deadCells);
            }
            
            if (cellState == 1 && aliveCells < 2) {
                cacheBoard[x, y] = 0;

                if (output) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Death (starvation)");
                    Console.ResetColor();
                }


                cellDeaths++;
                canContinue = false;
            }
            
            // Any live cell with two or three live neighbours lives on to the next generation.
            if (canContinue && (cellState == 1 && (aliveCells == 2 || aliveCells == 3)) ) {
                cacheBoard[x, y] = 1;

                if (output) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Life  (unchanged)");
                    Console.ResetColor();
                }

                cellBirths++;
                canContinue = false;
            }
            
            // Any live cell with more than three live neighbours dies, as if by overpopulation.
            if (canContinue && (cellState == 1 && aliveCells > 3)) {
                cacheBoard[x, y] = 0;
                
                if (output) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Death (overpopulation)");
                    Console.ResetColor();
                }

                cellDeaths++;
                canContinue = false;
            }
            
            // Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
            if (canContinue && (cellState == 0 && aliveCells == 3)) {
                cacheBoard[x, y] = 1;
                
                if (output) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Life  (birth)");
                    Console.ResetColor();
                }
                
                cellBirths++;
                canContinue = false;
            }

            // Anything else
            if (canContinue) {
                if (output)
                    Console.WriteLine("Death (unchanged)");
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

            // Apply new board state
            updateBoard();
        }

        public static void updateBoard() {
            GameOfLife.simulationBoard = cacheBoard;
        }
    }
}
