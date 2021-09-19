using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using Game_Of_Life.Simulation;

namespace Game_Of_Life
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();

            golBoard canvasForm = new golBoard();
            canvasForm.Show();
        }

        private void but_applyBoardDimensions_Click(object sender, EventArgs e) {
            int x = Convert.ToInt32(input_boardDimensionX.Value);
            int y = Convert.ToInt32(input_boardDimensionY.Value);

            GameOfLife.setBoardSize(x, y);
            
            if (!but_populateBoard.Enabled) {
                but_populateBoard.Enabled = true;
                but_simulationAdvance.Enabled = true;
            }
        }

        private void but_populateBoard_Click(object sender, EventArgs e) {
            Application.UseWaitCursor = true;

            GameOfLife.populateBoardRandom();
            Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" -> Done");
                Console.ResetColor();

            Application.UseWaitCursor = false;
            
            but_showSimulationBoard.Enabled = true;
        }

        private void but_showSimulationBoard_Click(object sender, EventArgs e) {
            int x = GameOfLife.simulationBoard.GetLength(0);
            int y = GameOfLife.simulationBoard.GetLength(1);

            // Print to file
            using (StreamWriter writer = new StreamWriter(@"C:\temp\golBoard.txt")) {
                for (int a = 0; a < x; a++)
                {
                    // Apply padding if neccesarry
                    if (a < 10) {
                        Console.Write("0{0} - ", a);
                    } else {
                        Console.Write("{0} - ", a);
                    }

                    for (int b = 0; b < y; b++) {
                        
                        writer.Write(GameOfLife.simulationBoard[a, b]);
                        Console.Write(GameOfLife.simulationBoard[a, b]);

                    }

                    writer.WriteLine("");
                    Console.WriteLine(" ");
                }
            }

            // Display board
            GameOfLife.renderBoard();

        }

        private void but_simulationAdvance_Click(object sender, EventArgs e) {
            int x = GameOfLife.simulationBoard.GetLength(0);
            int y = GameOfLife.simulationBoard.GetLength(1);

            for (int a = 0; a < x; a++) {
                for (int b = 0; b < y; b++) {
                    //Console.WriteLine("a,b = {0},{1}", a, b);
                    GameOfLifeLogic.processGameRule(a, b);
                }
            }

            // Update statistics
            label_cellBirthsValue.Text = GameOfLifeLogic.cellBirths.ToString();
            label_cellDeathsValue.Text = GameOfLifeLogic.cellDeaths.ToString();

            // Apply
            GameOfLifeLogic.updateBoard();
        }
    }
}
