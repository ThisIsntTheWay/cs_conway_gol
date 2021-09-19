using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    public class GameOfLife
    {
        internal static int[,] simulationBoard;    // 2D array
        internal static int x_midpoint;
        internal static int y_midpoint;

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

            // Init array and set midpoints.
            simulationBoard = new int[x_length, y_length];
            Console.WriteLine("[i] A board of the size {0} - {1} has been initialized.", x_length, y_length);

            x_midpoint = x_length / 2;
            y_midpoint = y_length / 2;
        }

        /// <summary>
        /// Populates the simulation board randomly.
        /// </summary>
        public static void populateBoardRandom() {
            Random rnd = new Random();

            int x = simulationBoard.GetLength(0);
            int y = simulationBoard.GetLength(1);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Populating board...");
            Console.ResetColor();

            // Populate array
            for (int i = 0; i < x - 1; i++) {

                simulationBoard[0, i] = rnd.Next(0, 1);
            }

            for (int i = 0; i < y - 1; i++) {
                simulationBoard[1, i] = rnd.Next(0, 1);
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
    }
}
