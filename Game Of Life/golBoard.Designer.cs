
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
            this.components = new System.ComponentModel.Container();
            this.picBox_golBoard = new System.Windows.Forms.PictureBox();
            this.timer_golBoardRender = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_golBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_golBoard
            // 
            this.picBox_golBoard.BackgroundImage = global::Game_Of_Life.Properties.Resources.black_square;
            this.picBox_golBoard.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picBox_golBoard.Enabled = false;
            this.picBox_golBoard.Location = new System.Drawing.Point(1, 1);
            this.picBox_golBoard.Name = "picBox_golBoard";
            this.picBox_golBoard.Size = new System.Drawing.Size(161, 140);
            this.picBox_golBoard.TabIndex = 0;
            this.picBox_golBoard.TabStop = false;
            this.picBox_golBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_golBoard_MouseDown);
            this.picBox_golBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_golBoard_MouseMove);
            this.picBox_golBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_golBoard_MouseUp);
            // 
            // timer_golBoardRender
            // 
            this.timer_golBoardRender.Enabled = true;
            this.timer_golBoardRender.Tick += new System.EventHandler(this.timer_golBoardRender_Tick);
            // 
            // golBoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(163, 140);
            this.ControlBox = false;
            this.Controls.Add(this.picBox_golBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "golBoardView";
            this.Text = "Game of Life - View";
            this.Load += new System.EventHandler(this.golBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_golBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picBox_golBoard;
        public System.Windows.Forms.Timer timer_golBoardRender;
    }
}