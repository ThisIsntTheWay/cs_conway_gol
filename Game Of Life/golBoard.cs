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
        
        private bool isDrawing = false;
        private bool isDeleting = false;
        private int globCellSize = 10;

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
                var cellSize = (grid) ? new Size(globCellSize - 1, globCellSize - 1) :
                                        new Size(globCellSize, globCellSize);

                int x_length = GameOfLife.simulationBoard.GetLength(0);
                int y_length = GameOfLife.simulationBoard.GetLength(1);

                for (int x = 0; x < x_length; x++) {
                    for (int y = 0; y < y_length; y++) {
                        if (simulationBoard[x, y] == 1) {
                            // Draw cell by making a rectangle
                            var cLocation = new Point(x * globCellSize, y * globCellSize);
                            var cRect = new Rectangle(cLocation, cellSize);
                            gfx.FillRectangle(brush, cRect);
                        }
                    }
                }
                
                // Align image the correct way
                //bmp.RotateFlip(RotateFlipType.Rotate90FlipX);

                // Temp save bmp as jpg
                //bmp.Save(@"C:\temp\golBoard.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

                // Draw generated image
                picBox_golBoard.Image = (Bitmap)bmp.Clone();
            }
        }

        private void timer_golBoardRender_Tick(object sender, EventArgs e) {
            // Render board
            if (GameOfLifeLogic.drawGrid) { renderBoard(true); }
            else { renderBoard(false); }
            
            if (newBoard) {
                // Dynamically resize window and picture box
                var h = picBox_golBoard.Image.Height;
                var w = picBox_golBoard.Image.Width;

                // The odd height and width offsets account for window size.
                this.Height = h + 40; picBox_golBoard.Height = h;
                this.Width = w + 18; picBox_golBoard.Width = w;
            }
        }

        private void picBox_golBoard_MouseDown(object sender, MouseEventArgs e) {
            // Set flags according to mousebutton input
            switch (e.Button) {
                case MouseButtons.Left:
                    isDrawing = true;

                    if (GameOfLifeLogic.verboseOutput)
                        Console.WriteLine("[i] Drawing mode is active.");
                    
                    break;
                case MouseButtons.Right:
                    isDeleting = true;

                    if (GameOfLifeLogic.verboseOutput)
                        Console.WriteLine("[i] Deletion mode is active.");
                    
                    break;
                default:
                    isDeleting = false;
                    isDrawing = false;
                    break;
            }

        }

        private void picBox_golBoard_MouseUp(object sender, MouseEventArgs e) {
            // Reset flags
            isDeleting = false;
            isDrawing = false;
        }

        private void picBox_golBoard_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
            var coordinates = e.Location;

            // Account for cell sizes
            var cell_x = (int)Math.Floor((decimal)coordinates.X / globCellSize);
            var cell_y = (int)Math.Floor((decimal)coordinates.Y / globCellSize);

            if (GameOfLifeLogic.verboseOutput2)
                Console.WriteLine("[i] MouseCell X/Y: {0}/{1}", cell_x, cell_y);

            // Perform action based on flag
            if (isDrawing) { GameOfLife.setCell(cell_x, cell_y, true); }
            else if (isDeleting) { GameOfLife.setCell(cell_x, cell_y, false); }
        }

        private void picBox_golBoard_Click(object sender, EventArgs e) {
            MouseEventArgs me = (MouseEventArgs)e;
            var coordinates = me.Location;

            // Account for cell sizes
            var cell_x = (int)Math.Floor((decimal)coordinates.X / globCellSize);
            var cell_y = (int)Math.Floor((decimal)coordinates.Y / globCellSize);

            GameOfLife.toggleCell(cell_x, cell_y);
        }
    }
}
