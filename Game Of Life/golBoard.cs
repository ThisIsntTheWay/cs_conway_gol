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
        private PictureBox picBox = new PictureBox();

        public golBoard() {
            InitializeComponent();
        }

        private void golBoard_Load(object sender, EventArgs e) {}
    }
}
