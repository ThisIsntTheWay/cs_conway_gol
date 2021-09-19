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
        public golBoard()
        {
            InitializeComponent();
        }

        private void golBoard_Load(object sender, EventArgs e) {}

        public void updateCanvas() {
            Console.WriteLine("[i] Updating golBoard...");
            this.Paint += Draw2DArray;
        }

        // https://stackoverflow.com/a/22425515

        /// <summary>
        /// Draws the simulation Board as rectangles.
        /// </summary>
        private void Draw2DArray(object sender, PaintEventArgs e)
        {
            int step = 50; //distance between the rows and columns
            int width = 40; //the width of the rectangle
            int height = 40; //the height of the rectangle

            using (Graphics g = this.CreateGraphics())
            {
                g.Clear(SystemColors.Control); //Clear the draw area
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    int rows = GameOfLife.simulationBoard.GetUpperBound(0) + 1 - GameOfLife.simulationBoard.GetLowerBound(0); // = 3, this value is not used
                    int columns = GameOfLife.simulationBoard.GetUpperBound(1) + 1 - GameOfLife.simulationBoard.GetLowerBound(1); // = 4

                    for (int index = 0; index < GameOfLife.simulationBoard.Length; index++)
                    {
                        int i = index / columns;
                        int j = index % columns;
                        if (GameOfLife.simulationBoard[i, j] == 1) 
                        {
                            Rectangle rect = new Rectangle(new Point(5 + step * j, 5 + step * i), new Size(width, height));
                            g.DrawRectangle(pen, rect);
                            g.FillRectangle(System.Drawing.Brushes.Red, rect);
                        }
                    }
                }
            }
        }
    }
}
