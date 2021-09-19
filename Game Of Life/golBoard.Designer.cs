
namespace Game_Of_Life {
    partial class golBoard {
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
            this.picBox_golBoard = new System.Windows.Forms.PictureBox();
            this.timer_golLogic = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_golBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_golBoard
            // 
            this.picBox_golBoard.Location = new System.Drawing.Point(1, 1);
            this.picBox_golBoard.Name = "picBox_golBoard";
            this.picBox_golBoard.Size = new System.Drawing.Size(798, 450);
            this.picBox_golBoard.TabIndex = 0;
            this.picBox_golBoard.TabStop = false;
            // 
            // timer_golLogic
            // 
            this.timer_golLogic.Enabled = true;
            this.timer_golLogic.Tick += new System.EventHandler(this.timer_golLogic_Tick);
            // 
            // golBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBox_golBoard);
            this.Name = "golBoard";
            this.Text = "golBoard";
            this.Load += new System.EventHandler(this.golBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_golBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picBox_golBoard;
        public System.Windows.Forms.Timer timer_golLogic;
    }
}