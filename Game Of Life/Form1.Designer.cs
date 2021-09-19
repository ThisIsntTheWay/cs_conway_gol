
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
            this.label_boardDimensionsHead = new System.Windows.Forms.Label();
            this.but_applyBoardDimensions = new System.Windows.Forms.Button();
            this.label_boardDimensionsDelimiter = new System.Windows.Forms.Label();
            this.input_boardDimensionX = new System.Windows.Forms.NumericUpDown();
            this.input_boardDimensionY = new System.Windows.Forms.NumericUpDown();
            this.but_populateBoard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.input_boardDimensionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_boardDimensionY)).BeginInit();
            this.SuspendLayout();
            // 
            // label_boardDimensionsHead
            // 
            this.label_boardDimensionsHead.AutoSize = true;
            this.label_boardDimensionsHead.Location = new System.Drawing.Point(298, 163);
            this.label_boardDimensionsHead.Name = "label_boardDimensionsHead";
            this.label_boardDimensionsHead.Size = new System.Drawing.Size(111, 13);
            this.label_boardDimensionsHead.TabIndex = 0;
            this.label_boardDimensionsHead.Text = "Set board dimensions:";
            // 
            // but_applyBoardDimensions
            // 
            this.but_applyBoardDimensions.Location = new System.Drawing.Point(301, 205);
            this.but_applyBoardDimensions.Name = "but_applyBoardDimensions";
            this.but_applyBoardDimensions.Size = new System.Drawing.Size(75, 23);
            this.but_applyBoardDimensions.TabIndex = 1;
            this.but_applyBoardDimensions.Text = "Apply";
            this.but_applyBoardDimensions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_applyBoardDimensions.UseVisualStyleBackColor = true;
            this.but_applyBoardDimensions.Click += new System.EventHandler(this.but_applyBoardDimensions_Click);
            // 
            // label_boardDimensionsDelimiter
            // 
            this.label_boardDimensionsDelimiter.AutoSize = true;
            this.label_boardDimensionsDelimiter.Location = new System.Drawing.Point(341, 183);
            this.label_boardDimensionsDelimiter.Name = "label_boardDimensionsDelimiter";
            this.label_boardDimensionsDelimiter.Size = new System.Drawing.Size(14, 13);
            this.label_boardDimensionsDelimiter.TabIndex = 2;
            this.label_boardDimensionsDelimiter.Text = "X";
            // 
            // input_boardDimensionX
            // 
            this.input_boardDimensionX.Cursor = System.Windows.Forms.Cursors.Default;
            this.input_boardDimensionX.Location = new System.Drawing.Point(301, 179);
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
            this.input_boardDimensionY.Location = new System.Drawing.Point(359, 180);
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
            this.but_populateBoard.Location = new System.Drawing.Point(301, 280);
            this.but_populateBoard.Name = "but_populateBoard";
            this.but_populateBoard.Size = new System.Drawing.Size(75, 23);
            this.but_populateBoard.TabIndex = 7;
            this.but_populateBoard.Text = "Populate";
            this.but_populateBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_populateBoard.UseVisualStyleBackColor = true;
            this.but_populateBoard.Click += new System.EventHandler(this.but_populateBoard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

