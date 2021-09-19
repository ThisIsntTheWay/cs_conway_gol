using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Game_Of_Life.GameOfLife;

namespace Game_Of_Life.Simulation {
    class GameOfLifeLogic {

        public static bool simulationState;     // State of simulation
        public static int generation;           // Current generation
        public static int cellMutations;        // Cell update count

        /// <summary>
        /// Processes the rules of game of life for a target cell.
        /// </summary>
        /// <param name="x">X coordinate of target cell.</param>
        /// <param name="y">Y coordinate of target cell.</param>
        /// <returns>True = processed rules succesfully
        /// False = x/y coordinate under-, or overflow.</returns>
        public static bool processGameRule(int x, int y) {
            int x_length = GameOfLife.simulationBoard.GetLength(0);
            int y_length = GameOfLife.simulationBoard.GetLength(1);

            // Sanity checks
            if (x > x_length || y > y_length) { return false; }

            // Process rules

            /* Game rules:
                1. Any live cell with fewer than two live neighbours dies, as if by underpopulation.
                2. Any live cell with two or three live neighbours lives on to the next generation.
                3. Any live cell with more than three live neighbours dies, as if by overpopulation.
                4. Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
            */

            int cellState = GameOfLife.simulationBoard[x, y];

            // Process rules for live cell

            // Process rule for dead cell

            return true;
        }
    }
}
