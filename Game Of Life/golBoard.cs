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
        }

        private void golBoard_Load(object sender, EventArgs e) {}

        private void timer_golLogic_Tick(object sender, EventArgs e) {
            renderBoard();
        }

        // https://swharden.com/CsharpDataVis/life/game-of-life-using-csharp.md.html
        /// <summary>
        /// Draws the simulation Board as rectangles.
        /// </summary>
        public void renderBoard() {
            //Console.WriteLine("renderBoard() called...");

            using (var bmp = new System.Drawing.Bitmap(simulationBoard.GetLength(1), simulationBoard.GetLength(0)))
            using (var gfx = System.Drawing.Graphics.FromImage(bmp))
            using (var brush = new System.Drawing.SolidBrush(Color.White))
            {
                //Console.WriteLine(" > Attempting to draw....");
                gfx.Clear(Color.Black);

                // Define sizes
                var globCellSize = 1;
                var cellSize = new Size(globCellSize, globCellSize);

                int x_length = GameOfLife.simulationBoard.GetLength(0);
                int y_length = GameOfLife.simulationBoard.GetLength(1);

                for (int x = 0; x < x_length; x++) {
                    for (int y = 0; y < y_length; y++) {
                        if (simulationBoard[x, y] == 1) {
                            //Console.WriteLine("! > Cell ({0}/{1}) is alive.", x, y);

                            // Draw cell by making a rectangle
                            var cLocation = new Point(x * globCellSize, y * globCellSize);
                            var cRect = new Rectangle(cLocation, cellSize);
                            gfx.FillRectangle(brush, cRect);
                        }
                    }
                }

                // Temp save bmp as jpg
                bmp.Save(@"C:\temp\output.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

                // Draw generated image
                //Console.WriteLine(" > Attempting to populate picBox....");
                picBox_golBoard.Image = (Bitmap)bmp.Clone();
            }
        }
    }
}
