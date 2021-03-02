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
    public partial class frmPaperScissorsRock : Form
    {
        int userSelection = 0;
        int botSelection = 0;
        public frmPaperScissorsRock()
        {
            InitializeComponent();
        }

        private void picPaper_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void picPaper_MouseHover(object sender, EventArgs e)
        {
            picPaper.Size = new Size(204, 170);
        }

        private void frmPaperScissorsRock_MouseHover(object sender, EventArgs e)
        {
            picPaper.Size = new Size(169, 141);
            picScissors.Size = new Size(169, 141);
            picRock.Size = new Size(169, 141);

        }

        private void picScissors_MouseHover(object sender, EventArgs e)
        {
            picScissors.Size = new Size(204, 170);
        }

        private void picRock_MouseHover(object sender, EventArgs e)
        {
            picRock.Size = new Size(204, 170);
        }

        private void picPaper_Click(object sender, EventArgs e)
        {

        }
    }
}
