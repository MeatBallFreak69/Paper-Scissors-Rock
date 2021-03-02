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
        int paper = 1;
        int scissors = 2;
        int rock = 3;
        bool done = false;
        bool playerWin = false;
        public frmPaperScissorsRock()
        {
            InitializeComponent();
        }

        private void picPaper_MouseDown(object sender, MouseEventArgs e)
        {
            userSelection = paper;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void picPaper_MouseHover(object sender, EventArgs e)
        {
            picPaper.Size = new Size(204, 170);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void frmPaperScissorsRock_MouseHover(object sender, EventArgs e)
        {
            picPaper.Size = new Size(169, 141);
            picScissors.Size = new Size(169, 141);
            picRock.Size = new Size(169, 141);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;

        }

        private void picScissors_MouseHover(object sender, EventArgs e)
        {
            picScissors.Size = new Size(204, 170);
        }

        private void picRock_MouseHover(object sender, EventArgs e)
        {
            picRock.Size = new Size(204, 170);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void frmPaperScissorsRock_Load(object sender, EventArgs e)
        {
            
            while (done == false)
            {
                if (userSelection == paper && botSelection == scissors) 
                {
                    playerWin = false;
                }
                else if (userSelection == scissors && botSelection == rock)
                {
                    playerWin = false;
                }
                else if (userSelection == rock && botSelection == paper)
                {
                    playerWin = false;
                }

            }

        }

        private void tmrPaperScissors_Tick(object sender, EventArgs e)
        {

        }
    }
}
