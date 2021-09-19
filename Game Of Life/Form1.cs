using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Of_Life
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void but_applyBoardDimensions_Click(object sender, EventArgs e) {
            int x = Convert.ToInt32(input_boardDimensionX.Value);
            int y = Convert.ToInt32(input_boardDimensionY.Value);

            GameOfLife.setBoardSize(x, y);
            
            if (!but_populateBoard.Enabled) {
                but_populateBoard.Enabled = true;
            }
        }

        private void but_populateBoard_Click(object sender, EventArgs e) {
            Application.UseWaitCursor = true;

            GameOfLife.populateBoardRandom();
            Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" -> Done");
                Console.ResetColor();

            Application.UseWaitCursor = false;
        }
    }
}
