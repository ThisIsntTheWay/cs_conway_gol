using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Game_Of_Life.GameOfLife;

namespace Game_Of_Life {
    public partial class golBoard : Form {
        private PictureBox picBox = new PictureBox();

        public golBoard() {
            InitializeComponent();
            this.Paint += Draw2DArray;
        }

        private void golBoard_Load(object sender, EventArgs e) {}

        public void updateCanvas() {
            Console.WriteLine("[i] Updating golBoard...");
            this.Paint += Draw2DArray;
        }

        // https://stackoverflow.com/a/2753591
        /// <summary>
        /// Draws the simulation Board as rectangles.
        /// </summary>
        private void Draw2DArray(object sender, PaintEventArgs e) {
            int numCells = simulationBoard.GetLength(0) * simulationBoard.GetLength(1);
            int cellSize = 10;

            Console.WriteLine("[i] Redrawing...");

            using (Graphics g = this.CreateGraphics()) {
                g.Clear(SystemColors.Control); //Clear the draw area
                Pen p = System.Drawing.Pens.Black;

                // Create grid
                for (int i = 0; i < numCells; i++) {
                    // Vertical / Y
                    g.DrawLine(p, i * cellSize, 0, i * cellSize, numCells * cellSize);
                    // Horizontal / X
                    g.DrawLine(p, 0, i * cellSize, numCells * cellSize, i * cellSize);
                }
            }
        }
    }
}
