
namespace Game_Of_Life
{
    partial class form_GoLControl
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
            this.but_simState = new System.Windows.Forms.Button();
            this.label_simControl = new System.Windows.Forms.Label();
            this.label_metricsHead = new System.Windows.Forms.Label();
            this.label_cellUpdateText = new System.Windows.Forms.Label();
            this.label_cellUpdateValue = new System.Windows.Forms.Label();
            this.label_simDeadCellsValue = new System.Windows.Forms.Label();
            this.label_simDeadCells = new System.Windows.Forms.Label();
            this.label_simBornCells = new System.Windows.Forms.Label();
            this.label_simBornCellsValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_simState
            // 
            this.but_simState.Location = new System.Drawing.Point(35, 39);
            this.but_simState.Name = "but_simState";
            this.but_simState.Size = new System.Drawing.Size(75, 23);
            this.but_simState.TabIndex = 0;
            this.but_simState.Text = "button1";
            this.but_simState.UseVisualStyleBackColor = true;
            this.but_simState.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_simControl
            // 
            this.label_simControl.AutoSize = true;
            this.label_simControl.CausesValidation = false;
            this.label_simControl.Location = new System.Drawing.Point(35, 20);
            this.label_simControl.Name = "label_simControl";
            this.label_simControl.Size = new System.Drawing.Size(81, 13);
            this.label_simControl.TabIndex = 1;
            this.label_simControl.Text = "Simulation state";
            this.label_simControl.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_metricsHead
            // 
            this.label_metricsHead.AutoSize = true;
            this.label_metricsHead.CausesValidation = false;
            this.label_metricsHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_metricsHead.Location = new System.Drawing.Point(153, 20);
            this.label_metricsHead.Name = "label_metricsHead";
            this.label_metricsHead.Size = new System.Drawing.Size(120, 13);
            this.label_metricsHead.TabIndex = 2;
            this.label_metricsHead.Text = "SImulation statistics";
            this.label_metricsHead.Click += new System.EventHandler(this.label_debugHead_Click);
            // 
            // label_cellUpdateText
            // 
            this.label_cellUpdateText.AutoSize = true;
            this.label_cellUpdateText.Location = new System.Drawing.Point(156, 48);
            this.label_cellUpdateText.Name = "label_cellUpdateText";
            this.label_cellUpdateText.Size = new System.Drawing.Size(68, 13);
            this.label_cellUpdateText.TabIndex = 3;
            this.label_cellUpdateText.Text = "Cell updates:";
            // 
            // label_cellUpdateValue
            // 
            this.label_cellUpdateValue.AutoSize = true;
            this.label_cellUpdateValue.Location = new System.Drawing.Point(230, 48);
            this.label_cellUpdateValue.Name = "label_cellUpdateValue";
            this.label_cellUpdateValue.Size = new System.Drawing.Size(39, 13);
            this.label_cellUpdateValue.TabIndex = 4;
            this.label_cellUpdateValue.Text = "<VAL>";
            // 
            // label_simDeadCellsValue
            // 
            this.label_simDeadCellsValue.AutoSize = true;
            this.label_simDeadCellsValue.Location = new System.Drawing.Point(230, 62);
            this.label_simDeadCellsValue.Name = "label_simDeadCellsValue";
            this.label_simDeadCellsValue.Size = new System.Drawing.Size(39, 13);
            this.label_simDeadCellsValue.TabIndex = 6;
            this.label_simDeadCellsValue.Text = "<VAL>";
            // 
            // label_simDeadCells
            // 
            this.label_simDeadCells.AutoSize = true;
            this.label_simDeadCells.Location = new System.Drawing.Point(156, 62);
            this.label_simDeadCells.Name = "label_simDeadCells";
            this.label_simDeadCells.Size = new System.Drawing.Size(45, 13);
            this.label_simDeadCells.TabIndex = 5;
            this.label_simDeadCells.Text = "> Dead:";
            this.label_simDeadCells.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_simBornCells
            // 
            this.label_simBornCells.AutoSize = true;
            this.label_simBornCells.Location = new System.Drawing.Point(156, 75);
            this.label_simBornCells.Name = "label_simBornCells";
            this.label_simBornCells.Size = new System.Drawing.Size(41, 13);
            this.label_simBornCells.TabIndex = 7;
            this.label_simBornCells.Text = "> Born:";
            // 
            // label_simBornCellsValue
            // 
            this.label_simBornCellsValue.AutoSize = true;
            this.label_simBornCellsValue.Location = new System.Drawing.Point(230, 75);
            this.label_simBornCellsValue.Name = "label_simBornCellsValue";
            this.label_simBornCellsValue.Size = new System.Drawing.Size(39, 13);
            this.label_simBornCellsValue.TabIndex = 8;
            this.label_simBornCellsValue.Text = "<VAL>";
            // 
            // form_GoLControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 124);
            this.Controls.Add(this.label_simBornCellsValue);
            this.Controls.Add(this.label_simBornCells);
            this.Controls.Add(this.label_simDeadCellsValue);
            this.Controls.Add(this.label_simDeadCells);
            this.Controls.Add(this.label_cellUpdateValue);
            this.Controls.Add(this.label_cellUpdateText);
            this.Controls.Add(this.label_metricsHead);
            this.Controls.Add(this.label_simControl);
            this.Controls.Add(this.but_simState);
            this.Name = "form_GoLControl";
            this.Text = "Simulation Control";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_simState;
        private System.Windows.Forms.Label label_simControl;
        private System.Windows.Forms.Label label_metricsHead;
        private System.Windows.Forms.Label label_cellUpdateText;
        private System.Windows.Forms.Label label_cellUpdateValue;
        private System.Windows.Forms.Label label_simDeadCellsValue;
        private System.Windows.Forms.Label label_simDeadCells;
        private System.Windows.Forms.Label label_simBornCells;
        private System.Windows.Forms.Label label_simBornCellsValue;
    }
}