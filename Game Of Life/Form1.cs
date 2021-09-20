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
        private static bool printedToUI;
        private static long startMillis, currMillis;

        public Form1() {
            InitializeComponent();

            golBoardView canvasForm = new golBoardView();
            canvasForm.Show();

            // "Hide" status labels
            label_printStatus.Text = " ";
            label_sysStatusText.Text = " ";

            // Set initial values for labels
            label_simSpeedValue.Text = scroll_simSpeed.Value.ToString() + " t/s";
        }

        private void but_applyBoardDimensions_Click(object sender, EventArgs e) {
            int x = Convert.ToInt32(input_boardDimensionX.Value);
            int y = Convert.ToInt32(input_boardDimensionY.Value);

            GameOfLife.setBoardSize(x, y);
            
            if (!but_populateBoard.Enabled) {
                but_populateBoard.Enabled = true;
                but_populateBoardFixed.Enabled = true;
                but_simulationAdvance.Enabled = true;
            }

            // Reset statistics
            GameOfLifeLogic.cellBirths = 0;
            GameOfLifeLogic.cellDeaths = 0;
            GameOfLifeLogic.generation = 0;
        }

        private void but_populateBoard_Click(object sender, EventArgs e) {
            GameOfLife.populateBoardRandom();
            Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" -> Done");
                Console.ResetColor();
            
            but_showSimulationBoard.Enabled = true;
            
            // Reset statistics
            GameOfLifeLogic.cellBirths = 0;
            GameOfLifeLogic.cellDeaths = 0;
            GameOfLifeLogic.generation = 0;
        }
        
        private void but_populateBoardFixed_Click(object sender, EventArgs e) {
            GameOfLife.populateBoardFixed();
            Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" -> Done");
                Console.ResetColor();
            
            but_showSimulationBoard.Enabled = true;
            
            // Reset statistics
            GameOfLifeLogic.cellBirths = 0;
            GameOfLifeLogic.cellDeaths = 0;
            GameOfLifeLogic.generation = 0;
        }

        private void but_showSimulationBoard_Click(object sender, EventArgs e) {
            int x = GameOfLife.simulationBoard.GetLength(0);
            int y = GameOfLife.simulationBoard.GetLength(1);

            Console.WriteLine("Generation: {0}", GameOfLifeLogic.generation);

            // Print to file
            using (StreamWriter writer = new StreamWriter(@"C:\temp\golBoard.txt")) {
                for (int a = 0; a < x; a++)
                {
                    // Apply padding if neccesarry
                    if (a + 1 < 10) {
                        Console.Write("0{0} - ", a + 1);
                    } else {
                        Console.Write("{0} - ", a + 1);
                    }

                    for (int b = 0; b < y; b++) {
                        
                        writer.Write(GameOfLife.simulationBoard[a, b]);
                        Console.Write(GameOfLife.simulationBoard[a, b]);

                    }

                    writer.WriteLine("");
                    Console.WriteLine(" ");
                }
            }
            
            Console.WriteLine(" ");

            // Notify UI
            printedToUI = true;
            startMillis = DateTimeOffset.Now.ToUnixTimeSeconds();
            label_printStatus.Text = @"Saved to C:\temp\.";
        }

        private void but_simulationAdvance_Click(object sender, EventArgs e) {
            GameOfLifeLogic.processGameRule();
        }

        private void check_autoSim_CheckedChanged(object sender, EventArgs e){
            if (check_autoSim.Checked) {
                GameOfLifeLogic.simulationState = true;
                but_simulationAdvance.Enabled = false;
            } else {
                GameOfLifeLogic.simulationState = false;
                but_simulationAdvance.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            // Update statistics
            label_cellBirthsValue.Text = GameOfLifeLogic.cellBirths.ToString();
            label_cellDeathsValue.Text = GameOfLifeLogic.cellDeaths.ToString();
            label_generationValue.Text = GameOfLifeLogic.generation.ToString();
        }

        private void check_verboseOutput_CheckedChanged(object sender, EventArgs e) {
            // Verbose output

            if (check_verboseOutput.Checked) {
                GameOfLifeLogic.verboseOutput = true;

                // Disable auto-advance due to lag
                check_autoSim.Checked = false;
                check_autoSim.Enabled = false;
            } else {
                GameOfLifeLogic.verboseOutput = false;
                check_autoSim.Enabled = true;
            }
        }

        private void check_drawGrid_CheckedChanged(object sender, EventArgs e) {
            if (check_drawGrid.Checked) { GameOfLifeLogic.drawGrid = true; }
            else { GameOfLifeLogic.drawGrid = false; }
        }

        private void timer_golLogic_Tick(object sender, EventArgs e) {
            if (GameOfLifeLogic.simulationState) {
                GameOfLifeLogic.processGameRule();
            }
        }

        private void scroll_simSpeed_Scroll(object sender, ScrollEventArgs e) {
            // Invert simSpeed as lower value = faster ticks.
            // If we didn't to this, then the right side of the slider would be the slowest, which wouldn't make much sense
            var simSpeed = scroll_simSpeed.Maximum - scroll_simSpeed.Value;

            // Prevent simsSpeed from reaching 0 to cirucment ArgumentOutOfRangeException
            if (simSpeed < 1) simSpeed = 1;

            label_simSpeedValue.Text = scroll_simSpeed.Value + " t/s";
            timer_golLogic.Interval = simSpeed;
        }

        private void timer_miscUI_Tick(object sender, EventArgs e) {
            currMillis = DateTimeOffset.Now.ToUnixTimeSeconds();

            // Disable auto-advance if any verbose2 is true
            if (GameOfLifeLogic.verboseOutput2) {
                check_autoSim.Enabled = false;
                label_sysStatusText.Text = "High verbosity.";
            }

            // Reset label_printStatus text
            if (printedToUI) {
                //Console.WriteLine("[i] currMillis ({0}) - startMillis {1} -> {2}", currMillis, startMillis, (currMillis - startMillis));
                if (currMillis - startMillis > (2)){
                    label_printStatus.Text = " ";
                    printedToUI = false;
                }
            }
        }
    }
}
