using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paper_Scissors_Rock
{
    public partial class frmInstructions : Form
    {
        public frmInstructions()
        {
            InitializeComponent();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPaperScissorsRock.Show();
        }
    }
}
