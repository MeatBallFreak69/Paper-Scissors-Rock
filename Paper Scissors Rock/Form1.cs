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
        bool playerWin = false;
        public frmPaperScissorsRock()
        {
            InitializeComponent();
        }

        private void picPaper_MouseDown(object sender, MouseEventArgs e)
        {
            userSelection = 1;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void picPaper_MouseHover(object sender, EventArgs e)
        {
            picPaper.Size = new Size(204, 170);
            picScissors.Size = new Size(169, 141);
            picRock.Size = new Size(169, 141);
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
            picPaper.Size = new Size(169, 141);
            picRock.Size = new Size(169, 141);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;

        }

        private void picRock_MouseHover(object sender, EventArgs e)
        {
            picRock.Size = new Size(204, 170);
            picPaper.Size = new Size(169, 141);
            picScissors.Size = new Size(169, 141);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void tmrPaperScissors_Tick(object sender, EventArgs e)
        {

        }

        private void picCombination_MouseHover(object sender, EventArgs e)
        {
            picPaper.Size = new Size(169, 141);
            picScissors.Size = new Size(169, 141);
            picRock.Size = new Size(169, 141);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        private void picComputer_MouseHover(object sender, EventArgs e)
        {
            picPaper.Size = new Size(169, 141);
            picScissors.Size = new Size(169, 141);
            picRock.Size = new Size(169, 141);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        private void lblInstructions_MouseHover(object sender, EventArgs e)
        {
            picPaper.Size = new Size(169, 141);
            picScissors.Size = new Size(169, 141);
            picRock.Size = new Size(169, 141);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        private void lblComputer_MouseHover(object sender, EventArgs e)
        {
            picPaper.Size = new Size(169, 141);
            picScissors.Size = new Size(169, 141);
            picRock.Size = new Size(169, 141);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        private void picScissors_MouseDown(object sender, MouseEventArgs e)
        {
            userSelection = 2;
        }

        private void picRock_MouseDown(object sender, MouseEventArgs e)
        {
            userSelection = 3; 
        }
    }
}
