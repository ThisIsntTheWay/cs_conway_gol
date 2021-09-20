using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Of_Life.Simulation;
using static Game_Of_Life.GameOfLife;

namespace Game_Of_Life {
    public partial class golBoardView : Form {
        private PictureBox picBox = new PictureBox();

        public golBoardView() {
            InitializeComponent();
        }

        private void golBoard_Load(object sender, EventArgs e) {}

        private void timer_golLogic_Tick(object sender, EventArgs e) {
            if (GameOfLifeLogic.drawGrid) { renderBoard(true); }
            else { renderBoard(false); }

            /*
            // Dynamically resize picture box and window.
            var height = GameOfLife.simulationBoard.GetLength(0);
            var width = GameOfLife.simulationBoard.GetLength(1);
            
            this.Height = height;
            this.Width = width;

            picBox_golBoard.Height = height;
            picBox_golBoard.Width = width;
            */
        }

        // https://swharden.com/CsharpDataVis/life/game-of-life-using-csharp.md.html
        /// <summary>
        /// Draws the simulation Board as rectangles.
        /// </summary>
        /// <param name="grid">If set to true, draw a grid.</param>
        public void renderBoard(bool grid) {
            //Console.WriteLine("renderBoard() called...");

            var l = simulationBoard.GetLength(1);
            var w = simulationBoard.GetLength(0);

            using (var bmp = new System.Drawing.Bitmap(l * 10, w * 10))
            using (var gfx = System.Drawing.Graphics.FromImage(bmp))
            using (var brush = new System.Drawing.SolidBrush(Color.White))
            {
                gfx.Clear(Color.Black);

                // Define sizes
                var globCellSize = 10;
                var cellSize = (grid) ? new Size(globCellSize - 1, globCellSize - 1) :
                                        new Size(globCellSize, globCellSize);

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
                
                // Align image the correct way
                bmp.RotateFlip(RotateFlipType.Rotate90FlipX);

                // Temp save bmp as jpg
                //bmp.Save(@"C:\temp\golBoard.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

                // Draw generated image
                //Console.WriteLine(" > Attempting to populate picBox....");
                picBox_golBoard.Image = (Bitmap)bmp.Clone();
            }
        }

        private void timer_golBoardRender_Tick(object sender, EventArgs e) {
            if (GameOfLifeLogic.drawGrid) { renderBoard(true); }
            else { renderBoard(false); }
        }
    }
}
