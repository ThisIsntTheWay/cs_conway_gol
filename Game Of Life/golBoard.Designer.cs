
namespace Game_Of_Life {
    partial class golBoardView {
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
            this.picBox_golBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_golBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_golBoard
            // 
            this.picBox_golBoard.Location = new System.Drawing.Point(1, 1);
            this.picBox_golBoard.Name = "picBox_golBoard";
            this.picBox_golBoard.Size = new System.Drawing.Size(837, 437);
            this.picBox_golBoard.TabIndex = 0;
            this.picBox_golBoard.TabStop = false;
            // 
            // golBoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 435);
            this.ControlBox = false;
            this.Controls.Add(this.picBox_golBoard);
            this.Name = "golBoardView";
            this.Text = "golBoardView";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.golBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_golBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picBox_golBoard;
    }
}