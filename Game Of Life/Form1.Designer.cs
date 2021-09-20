
namespace Game_Of_Life
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_boardDimensionsHead = new System.Windows.Forms.Label();
            this.but_applyBoardDimensions = new System.Windows.Forms.Button();
            this.label_boardDimensionsDelimiter = new System.Windows.Forms.Label();
            this.input_boardDimensionX = new System.Windows.Forms.NumericUpDown();
            this.input_boardDimensionY = new System.Windows.Forms.NumericUpDown();
            this.but_populateBoard = new System.Windows.Forms.Button();
            this.but_showSimulationBoard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.but_simulationAdvance = new System.Windows.Forms.Button();
            this.label_bornCellsHead = new System.Windows.Forms.Label();
            this.label_cellBirthsValue = new System.Windows.Forms.Label();
            this.label_cellDeathsValue = new System.Windows.Forms.Label();
            this.label_cellDeathsHead = new System.Windows.Forms.Label();
            this.check_autoSim = new System.Windows.Forms.CheckBox();
            this.timer_statisticsWDT = new System.Windows.Forms.Timer(this.components);
            this.label_printStatus = new System.Windows.Forms.Label();
            this.timer_miscUI = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.input_boardDimensionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_boardDimensionY)).BeginInit();
            this.SuspendLayout();
            // 
            // label_boardDimensionsHead
            // 
            this.label_boardDimensionsHead.AutoSize = true;
            this.label_boardDimensionsHead.Location = new System.Drawing.Point(12, 9);
            this.label_boardDimensionsHead.Name = "label_boardDimensionsHead";
            this.label_boardDimensionsHead.Size = new System.Drawing.Size(111, 13);
            this.label_boardDimensionsHead.TabIndex = 0;
            this.label_boardDimensionsHead.Text = "Set board dimensions:";
            // 
            // but_applyBoardDimensions
            // 
            this.but_applyBoardDimensions.Location = new System.Drawing.Point(15, 51);
            this.but_applyBoardDimensions.Name = "but_applyBoardDimensions";
            this.but_applyBoardDimensions.Size = new System.Drawing.Size(70, 23);
            this.but_applyBoardDimensions.TabIndex = 1;
            this.but_applyBoardDimensions.Text = "Apply";
            this.but_applyBoardDimensions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_applyBoardDimensions.UseVisualStyleBackColor = true;
            this.but_applyBoardDimensions.Click += new System.EventHandler(this.but_applyBoardDimensions_Click);
            // 
            // label_boardDimensionsDelimiter
            // 
            this.label_boardDimensionsDelimiter.AutoSize = true;
            this.label_boardDimensionsDelimiter.Location = new System.Drawing.Point(55, 29);
            this.label_boardDimensionsDelimiter.Name = "label_boardDimensionsDelimiter";
            this.label_boardDimensionsDelimiter.Size = new System.Drawing.Size(14, 13);
            this.label_boardDimensionsDelimiter.TabIndex = 2;
            this.label_boardDimensionsDelimiter.Text = "X";
            // 
            // input_boardDimensionX
            // 
            this.input_boardDimensionX.Cursor = System.Windows.Forms.Cursors.Default;
            this.input_boardDimensionX.Location = new System.Drawing.Point(15, 25);
            this.input_boardDimensionX.Name = "input_boardDimensionX";
            this.input_boardDimensionX.Size = new System.Drawing.Size(38, 20);
            this.input_boardDimensionX.TabIndex = 5;
            this.input_boardDimensionX.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // input_boardDimensionY
            // 
            this.input_boardDimensionY.Location = new System.Drawing.Point(73, 26);
            this.input_boardDimensionY.Name = "input_boardDimensionY";
            this.input_boardDimensionY.Size = new System.Drawing.Size(38, 20);
            this.input_boardDimensionY.TabIndex = 6;
            this.input_boardDimensionY.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // but_populateBoard
            // 
            this.but_populateBoard.Enabled = false;
            this.but_populateBoard.Location = new System.Drawing.Point(15, 80);
            this.but_populateBoard.Name = "but_populateBoard";
            this.but_populateBoard.Size = new System.Drawing.Size(70, 23);
            this.but_populateBoard.TabIndex = 7;
            this.but_populateBoard.Text = "Populate";
            this.but_populateBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_populateBoard.UseVisualStyleBackColor = true;
            this.but_populateBoard.Click += new System.EventHandler(this.but_populateBoard_Click);
            // 
            // but_showSimulationBoard
            // 
            this.but_showSimulationBoard.Enabled = false;
            this.but_showSimulationBoard.Location = new System.Drawing.Point(15, 109);
            this.but_showSimulationBoard.Name = "but_showSimulationBoard";
            this.but_showSimulationBoard.Size = new System.Drawing.Size(70, 23);
            this.but_showSimulationBoard.TabIndex = 8;
            this.but_showSimulationBoard.Text = "Print board";
            this.but_showSimulationBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_showSimulationBoard.UseVisualStyleBackColor = true;
            this.but_showSimulationBoard.Click += new System.EventHandler(this.but_showSimulationBoard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Simulation control";
            // 
            // but_simulationAdvance
            // 
            this.but_simulationAdvance.Enabled = false;
            this.but_simulationAdvance.Location = new System.Drawing.Point(15, 160);
            this.but_simulationAdvance.Name = "but_simulationAdvance";
            this.but_simulationAdvance.Size = new System.Drawing.Size(61, 23);
            this.but_simulationAdvance.TabIndex = 10;
            this.but_simulationAdvance.Text = "Advance";
            this.but_simulationAdvance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_simulationAdvance.UseVisualStyleBackColor = true;
            this.but_simulationAdvance.Click += new System.EventHandler(this.but_simulationAdvance_Click);
            // 
            // label_bornCellsHead
            // 
            this.label_bornCellsHead.AutoSize = true;
            this.label_bornCellsHead.Location = new System.Drawing.Point(14, 202);
            this.label_bornCellsHead.Name = "label_bornCellsHead";
            this.label_bornCellsHead.Size = new System.Drawing.Size(55, 13);
            this.label_bornCellsHead.TabIndex = 11;
            this.label_bornCellsHead.Text = "Cell births:";
            // 
            // label_cellBirthsValue
            // 
            this.label_cellBirthsValue.AutoSize = true;
            this.label_cellBirthsValue.Location = new System.Drawing.Point(72, 202);
            this.label_cellBirthsValue.Name = "label_cellBirthsValue";
            this.label_cellBirthsValue.Size = new System.Drawing.Size(13, 13);
            this.label_cellBirthsValue.TabIndex = 12;
            this.label_cellBirthsValue.Text = "0";
            // 
            // label_cellDeathsValue
            // 
            this.label_cellDeathsValue.AutoSize = true;
            this.label_cellDeathsValue.Location = new System.Drawing.Point(72, 215);
            this.label_cellDeathsValue.Name = "label_cellDeathsValue";
            this.label_cellDeathsValue.Size = new System.Drawing.Size(13, 13);
            this.label_cellDeathsValue.TabIndex = 14;
            this.label_cellDeathsValue.Text = "0";
            // 
            // label_cellDeathsHead
            // 
            this.label_cellDeathsHead.AutoSize = true;
            this.label_cellDeathsHead.Location = new System.Drawing.Point(14, 215);
            this.label_cellDeathsHead.Name = "label_cellDeathsHead";
            this.label_cellDeathsHead.Size = new System.Drawing.Size(62, 13);
            this.label_cellDeathsHead.TabIndex = 13;
            this.label_cellDeathsHead.Text = "Cell deaths:";
            // 
            // check_autoSim
            // 
            this.check_autoSim.AutoSize = true;
            this.check_autoSim.Location = new System.Drawing.Point(82, 164);
            this.check_autoSim.Name = "check_autoSim";
            this.check_autoSim.Size = new System.Drawing.Size(93, 17);
            this.check_autoSim.TabIndex = 15;
            this.check_autoSim.Text = "Auto-advance";
            this.check_autoSim.UseVisualStyleBackColor = true;
            this.check_autoSim.CheckedChanged += new System.EventHandler(this.check_autoSim_CheckedChanged);
            // 
            // timer_statisticsWDT
            // 
            this.timer_statisticsWDT.Enabled = true;
            this.timer_statisticsWDT.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_printStatus
            // 
            this.label_printStatus.AutoSize = true;
            this.label_printStatus.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label_printStatus.Location = new System.Drawing.Point(91, 114);
            this.label_printStatus.Name = "label_printStatus";
            this.label_printStatus.Size = new System.Drawing.Size(0, 13);
            this.label_printStatus.TabIndex = 16;
            // 
            // timer_miscUI
            // 
            this.timer_miscUI.Enabled = true;
            this.timer_miscUI.Tick += new System.EventHandler(this.timer_miscUI_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 240);
            this.Controls.Add(this.label_printStatus);
            this.Controls.Add(this.check_autoSim);
            this.Controls.Add(this.label_cellDeathsValue);
            this.Controls.Add(this.label_cellDeathsHead);
            this.Controls.Add(this.label_cellBirthsValue);
            this.Controls.Add(this.label_bornCellsHead);
            this.Controls.Add(this.but_simulationAdvance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_showSimulationBoard);
            this.Controls.Add(this.but_populateBoard);
            this.Controls.Add(this.input_boardDimensionY);
            this.Controls.Add(this.input_boardDimensionX);
            this.Controls.Add(this.label_boardDimensionsDelimiter);
            this.Controls.Add(this.but_applyBoardDimensions);
            this.Controls.Add(this.label_boardDimensionsHead);
            this.Name = "Form1";
            this.Text = "Conway\'s Game of Life";
            ((System.ComponentModel.ISupportInitialize)(this.input_boardDimensionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_boardDimensionY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_boardDimensionsHead;
        private System.Windows.Forms.Button but_applyBoardDimensions;
        private System.Windows.Forms.Label label_boardDimensionsDelimiter;
        private System.Windows.Forms.NumericUpDown input_boardDimensionX;
        private System.Windows.Forms.NumericUpDown input_boardDimensionY;
        private System.Windows.Forms.Button but_populateBoard;
        private System.Windows.Forms.Button but_showSimulationBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_simulationAdvance;
        private System.Windows.Forms.Label label_bornCellsHead;
        private System.Windows.Forms.Label label_cellBirthsValue;
        private System.Windows.Forms.Label label_cellDeathsValue;
        private System.Windows.Forms.Label label_cellDeathsHead;
        private System.Windows.Forms.CheckBox check_autoSim;
        private System.Windows.Forms.Timer timer_statisticsWDT;
        private System.Windows.Forms.Label label_printStatus;
        private System.Windows.Forms.Timer timer_miscUI;
    }
}

