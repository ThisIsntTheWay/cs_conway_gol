using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    public class GameOfLife
    {
        public static int[,] simulationBoard;
        public static int[,] cacheBoard;                // Copy of simulationBoard
        internal static bool hasInitialized = false;

        /// <summary>
        /// GameOfLife class constructor.
        /// Initializes the simulation board.
        /// </summary>
        /// <param name="x_length">Max possible length of X axis.</param>
        /// <param name="y_length">max possible length of Y axis.</param>
        public static void setBoardSize(int x_length, int y_length) {
            // Sanity checks
            if (x_length % 2 != 0) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Warning: x_length ({0}) not divisible by two.", x_length);
                Console.WriteLine("Decreased by 1 to: {0}.", x_length - 1);
                Console.ResetColor();

                x_length -= 1;
            }

            if (y_length % 2 != 0) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Warning: y_ength ({0}) not divisible by two.", y_length);
                Console.WriteLine("Decreased by 1 to: {0}.", y_length - 1);
                Console.ResetColor();

                y_length -= 1;
            }

            // Init arrays
            simulationBoard = new int[x_length, y_length];
            cacheBoard = simulationBoard;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[i] A simulation board with size '{0}' x '{1}' has been initialized.", x_length, y_length);
            Console.WriteLine(" > X Length: {0}", simulationBoard.GetLength(0));
            Console.WriteLine(" > Y Length: {0}", simulationBoard.GetLength(1));
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
            if (x > x_length) { return 1; }
            if (y > y_length) { return 2; }
            
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
            if (x > x_length) { return 1; }
            if (y > y_length) { return 2; }

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

        /// <summary>
        /// See if the board has been set up.
        /// </summary>
        /// <returns>Returns hasInitialized.</returns>
        public static bool boardIsSetUp() {
            return hasInitialized;
        }
    }
}
