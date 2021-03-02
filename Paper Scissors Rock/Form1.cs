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
            picPaper.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void frmPaperScissorsRock_MouseHover(object sender, EventArgs e)
        {
            picPaper.SizeMode = PictureBoxSizeMode.Zoom;
            picScissors.SizeMode = PictureBoxSizeMode.Zoom;
            picRock.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void picScissors_MouseHover(object sender, EventArgs e)
        {
            picScissors.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void picRock_MouseHover(object sender, EventArgs e)
        {
            picRock.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void picPaper_Click(object sender, EventArgs e)
        {

        }
    }
}
