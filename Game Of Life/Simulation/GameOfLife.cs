using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    public class GameOfLife
    {
        public static int[,] simulationBoard;
        public static bool newBoard = true;

        internal static bool hasInitialized = false;

        /// <summary>
        /// GameOfLife class constructor.
        /// Initializes the simulation board.
        /// </summary>
        /// <param name="x_length">Max possible length of X axis.</param>
        /// <param name="y_length">max possible length of Y axis.</param>
        public static void setBoardSize(int x_length, int y_length) {
            newBoard = true;

            // Init arrays
            simulationBoard = new int[x_length, y_length];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[i] A simulation board with size '{0}' x '{1}' has been initialized.", x_length, y_length);
            Console.ResetColor();

            hasInitialized = true;
        }

        /// <summary>
        /// Populates the simulation board randomly.
        /// </summary>
        public static void populateBoardRandom() {
            if (!hasInitialized) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[X] Cannot populate board as it has not yet been initialized.");
                Console.ResetColor();
                return;
            }

            Random rnd = new Random();

            int x = simulationBoard.GetLength(0);
            int y = simulationBoard.GetLength(1);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Populating board...");
            Console.ResetColor();

            // Populate array
            for (int a = 0; a < x; a++) {
                for (int b = 0; b < y; b++) {
                    // Upper bound must be 2 to get 1s
                    var rand = rnd.Next(0, 2);

                    //Console.WriteLine("a: {0}, b: {1} -> {2}", a, b, rand);
                    simulationBoard[a, b] = rand;
                }
            }
        }

        /// <summary>
        /// Populates the simulation board using known shapes
        /// </summary>
        public static void populateBoardFixed() {
            if (!hasInitialized) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[X] Cannot populate board as it has not yet been initialized.");
                Console.ResetColor();
                return;
            }

            int x = simulationBoard.GetLength(0);
            int y = simulationBoard.GetLength(1);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Populating board with fixed shapes...");
            Console.ResetColor();

            // Populate array - Assuming at least 50x50
            // Clear array
            for (int a = 0; a < x; a++) {
                for (int b = 0; b < y; b++) {
                    simulationBoard[a, b] = 0;
                }
            }

            // Glider
            var xMid = x / 2;
            var yMid = y / 2;
            
            simulationBoard[xMid - 1, yMid + 1] = 1;    // > Top
            simulationBoard[xMid, yMid - 1]     = 1;    // > Middle
            simulationBoard[xMid, yMid + 1]     = 1;    // > Middle
            simulationBoard[xMid + 1, yMid]     = 1;    // > Bottom
            simulationBoard[xMid + 1, yMid + 1] = 1;    // > Bottom
        }

        /// <summary>
        /// Toggles a cell state at a specific board position.
        /// </summary>
        /// <param name="x">X coordinate of target cell.</param>
        /// <param name="y">Y coordinate of target cell.</param>
        /// <returns>0 if OK, non-zero if not OK:
        /// 1 -> x too large.
        /// 2 -> y too large.</returns>
        public static int toggleCell(int x, int y) {
            int x_length = simulationBoard.GetLength(0);
            int y_length = simulationBoard.GetLength(1);

            // Sanity checks
            if (x < 0 || x > x_length - 1) { return 1; }
            if (y < 0 || y > y_length - 1) { return 2; }
            
            // Toggle cell
            else {
                if (simulationBoard[x, y] == 0) { simulationBoard[x, y] = 1; }
                else { simulationBoard[x, y] = 0; }
                return 0;
            }
        }

        /// <summary>
        /// Sets a specific state of a cell.
        /// </summary>
        /// <param name="x">X coordinate of target cell.</param>
        /// <param name="y">Y coordinate of target cell.</param>
        /// <param name="state">State of cell, true = alive, false = dead.</param>
        /// <returns>0 if OK, non-zero if not OK:
        /// 1 -> x too large.
        /// 2 -> y too large.</returns>
        public static int setCell(int x, int y, bool state) {
            int x_length = simulationBoard.GetLength(0);
            int y_length = simulationBoard.GetLength(1);

            // Sanity checks
            if (x < 0 || x > x_length - 1) { return 1; }
            if (y < 0 || y > y_length - 1) { return 2; }

            // Set cell value, but "convert" bool to int beforehand
            int cellValue;
            if (state) cellValue = 1;
            else { cellValue = 0; }

            simulationBoard[x, y] = cellValue;
            return 0;
        }

        /// <summary>
        /// Sets a specific state of a cell.
        /// </summary>
        /// <param name="x">X coordinate of target cell.</param>
        /// <param name="y">Y coordinate of target cell.</param>
        /// <returns>True = alive, false = dead.</returns>
        public static bool getCell(int x, int y) {
            int x_length = simulationBoard.GetLength(0);
            int y_length = simulationBoard.GetLength(1);

            // Sanity checks
            if (x > x_length) { return false; }
            if (y > y_length) { return false; }

            // Toggle cell
            else {
                if (simulationBoard[x, y] == 0) { return true;  }
                else { return false; }
            }
        }
    }
}
