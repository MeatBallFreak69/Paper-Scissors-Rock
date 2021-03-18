using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paper_Scissors_Rock
{
    public partial class frmPaperScissorsRock : Form
    {
        SoundPlayer sound;
        int userSelection = 0;
        int botSelection = 0;
        bool playerWin = false;
        bool playerTie = false;
        int paperScissorsTick = 0;
        int scissorsRockTick = 0;
        int rockPaperTick = 0;
        int paperTieTick = 0;
        int scissorsTieTick = 0;
        int rockTieTick = 0;
        int randomEnemyMoveDisplayTick = 0;
        double Money = 5;
        double betAmount = 0;
        Random enemyMoveDisplay = new Random();
        Random enemyTurn = new Random();
        int enemyMoveDisplayValue = 0;
        public frmPaperScissorsRock()
        {
            InitializeComponent();
        }
        private void picPaper_MouseDown(object sender, MouseEventArgs e)
        {
            userSelection = 1;
            nudBet.Visible = false;
            if (botSelection == 0)
            {
                tmrERPS.Start();
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }
        private void picPaper_MouseHover(object sender, EventArgs e)
        {
            if (botSelection == 0) 
            {
                picPaper.Size = new Size(204, 170);
            }
            sound = new SoundPlayer(Properties.Resources.Paper);
            sound.Play();
            picScissors.Size = new Size(169, 141);
            picRock.Size = new Size(169, 141);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }
        private void frmPaperScissorsRock_MouseHover(object sender, EventArgs e)
        {
            sound.Stop();
            picPaper.Size = new Size(169, 141);
            picScissors.Size = new Size(169, 141);
            picRock.Size = new Size(169, 141);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;

        }
        private void picScissors_MouseHover(object sender, EventArgs e)
        {
            if (botSelection == 0)
            {
                picScissors.Size = new Size(204, 170);
            }
            sound = new SoundPlayer(Properties.Resources.Scissors1);
            sound.Play();
            picPaper.Size = new Size(169, 141);
            picRock.Size = new Size(169, 141);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;

        }
        private void picRock_MouseHover(object sender, EventArgs e)
        {
            if (botSelection == 0)
            {
                picRock.Size = new Size(204, 170);
            }
            sound = new SoundPlayer(Properties.Resources.Rock1);
            sound.Play();
            picPaper.Size = new Size(169, 141);
            picScissors.Size = new Size(169, 141);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }
        private void tmrPaperScissors_Tick(object sender, EventArgs e)
        {
            paperScissorsTick += 1;
            if (paperScissorsTick == 10)
            {
                picCombination.Image = Paper_Scissors_Rock.Properties.Resources._5893958b8370b70e212f3e62;
            }
            if (paperScissorsTick == 20)
            {
                picCombination.Image = Paper_Scissors_Rock.Properties.Resources.Scissors;
            }
            if (paperScissorsTick == 30)
            {
                picCombination.Image = Paper_Scissors_Rock.Properties.Resources.Tp_Cut;
            }
            if (paperScissorsTick == 45)
            {
                paperScissorsTick = 0;
                tmrPaperScissors.Stop();
                if (playerWin == true)
                {
                    MessageBox.Show("Nice, you won!", "Congratulations!");
                    lstBoxScores.Items.Add("Player Win");
                    Money += betAmount;
                    nudBet.Visible = true;
                    lblMoney.Text = ($"Money: ${Money}");
                }
                else if (playerWin == false)
                {
                    MessageBox.Show("Sorry, you lost!", "Sorry!");
                    lstBoxScores.Items.Add("Player Loss");
                    Money -= betAmount;
                    nudBet.Visible = true;
                    lblMoney.Text = ($"Money: ${Money}");
                }
                botSelection = 0;
                picPaper.BackColor = Color.Transparent;
                picScissors.BackColor = Color.Transparent;
                picRock.BackColor = Color.Transparent;
            }
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
            nudBet.Visible = false;
            if (botSelection == 0)
            {
                tmrERPS.Start();
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }
        private void picRock_MouseDown(object sender, MouseEventArgs e)
        {
            userSelection = 3;
            nudBet.Visible = false;
            if (botSelection == 0)
            {
                tmrERPS.Start();
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }
        private void tmrScissorsRock_Tick(object sender, EventArgs e)
        {
            scissorsRockTick += 1;
            if (paperScissorsTick == 10)
            {
                picCombination.Image = Paper_Scissors_Rock.Properties.Resources.Scissors;
            }
            if (scissorsRockTick == 20)
            {
                picCombination.Image = Paper_Scissors_Rock.Properties.Resources.Rock;
            }
            if (scissorsRockTick == 30)
            {
                picCombination.Image = Paper_Scissors_Rock.Properties.Resources.Smashed_Hand;
            }
            if (scissorsRockTick == 45)
            {
                tmrScissorsRock.Stop();
                scissorsRockTick = 0;
                if (playerWin == true)
                {
                    MessageBox.Show("Nice, you won!", "Congratulations!");
                    lstBoxScores.Items.Add("Player Win");
                    Money += betAmount;
                    nudBet.Visible = true;
                    lblMoney.Text = ($"Money: ${Money}");
                }
                else if (playerWin == false)
                {
                    MessageBox.Show("Sorry, you lost!", "Sorry!");
                    lstBoxScores.Items.Add("Player Loss");
                    Money -= betAmount;
                    nudBet.Visible = true;
                    lblMoney.Text = ($"Money: ${Money}");
                }
                botSelection = 0;
                picPaper.BackColor = Color.Transparent;
                picScissors.BackColor = Color.Transparent;
                picRock.BackColor = Color.Transparent;
            }
        }
        private void tmrRockPaper_Tick(object sender, EventArgs e)
        {
            rockPaperTick += 1;
            if (rockPaperTick == 10)
            {
                picCombination.Image = Paper_Scissors_Rock.Properties.Resources.Rock;
            }
            if (rockPaperTick == 20)
            {
                picCombination.Image = Paper_Scissors_Rock.Properties.Resources._5893958b8370b70e212f3e62;
            }
            if (rockPaperTick == 30)
            {
                picCombination.Image = Paper_Scissors_Rock.Properties.Resources.Rock_Covered_In_Toilet_Paper;
            }
            if (rockPaperTick == 45)
            {
                tmrRockPaper.Stop();
                rockPaperTick = 0;
                if (playerWin == true)
                {
                    MessageBox.Show("Nice, you won!", "Congratulations!");
                    lstBoxScores.Items.Add("Player Win");
                    Money += betAmount;
                    nudBet.Visible = true;
                    lblMoney.Text = ($"Money: ${Money}");
                }
                else if (playerWin == false)
                {
                    MessageBox.Show("Sorry, you lost!", "Sorry!");
                    lstBoxScores.Items.Add("Player Loss");
                    Money -= betAmount;
                    nudBet.Visible = true;
                    lblMoney.Text = ($"Money: ${Money}");
                }
                botSelection = 0;
                picPaper.BackColor = Color.Transparent;
                picScissors.BackColor = Color.Transparent;
                picRock.BackColor = Color.Transparent;
            }
        }
        private void picPaper_MouseUp(object sender, MouseEventArgs e)
        {
            tmrERPS.Start();
        }
        private void tmrTiePaper_Tick(object sender, EventArgs e)
        {
            paperTieTick += 1;
            if (paperTieTick == 10)
            {
                picCombination.Image = Paper_Scissors_Rock.Properties.Resources._5893958b8370b70e212f3e62;
            }
            if (paperTieTick == 20)
            {
                picCombination.Image = Paper_Scissors_Rock.Properties.Resources.TieTp;
            }
            if (paperTieTick == 35)
            {
                paperTieTick = 0;
                tmrTiePaper.Stop();
                if (playerTie == true)
                {
                    MessageBox.Show("Nice, you tied!", "Tie!");
                    lstBoxScores.Items.Add("Player Tie");
                    nudBet.Value = 0;
                    nudBet.Visible = true;
                    lblMoney.Text = ($"Money: ${Money}");
                }
                botSelection = 0;
                picPaper.BackColor = Color.Transparent;
                picScissors.BackColor = Color.Transparent;
                picRock.BackColor = Color.Transparent;
            }
        }
        private void tmrTieScissors_Tick(object sender, EventArgs e)
        {
            scissorsTieTick += 1;
            if (scissorsTieTick == 10)
            {
                picCombination.Image = Paper_Scissors_Rock.Properties.Resources.Scissors;
            }
            if (scissorsTieTick == 20)
            {
                picCombination.Image = Paper_Scissors_Rock.Properties.Resources.TieScissors;
            }
            if (scissorsTieTick == 35)
            {
                scissorsTieTick = 0;
                tmrTieScissors.Stop();
                if (playerTie == true)
                {
                    MessageBox.Show("Nice, you tied!", "Tie!");
                    lstBoxScores.Items.Add("Player Tie");
                    nudBet.Value = 0;
                    nudBet.Visible = true;
                    lblMoney.Text = ($"Money: ${Money}");
                }
                botSelection = 0;
                picPaper.BackColor = Color.Transparent;
                picScissors.BackColor = Color.Transparent;
                picRock.BackColor = Color.Transparent;
            }
        }
        private void tmrTieRock_Tick(object sender, EventArgs e)
        {
            rockTieTick += 1;
            if (rockTieTick == 10)
            {
                picCombination.Image = Paper_Scissors_Rock.Properties.Resources.Rock;
            }
            if (rockTieTick == 20)
            {
                picCombination.Image = Paper_Scissors_Rock.Properties.Resources.TieRock;
            }
            if (rockTieTick == 35)
            {
                tmrTieRock.Stop();
                rockTieTick = 0;
                if (playerTie == true)
                {
                    MessageBox.Show("Nice, you tied!", "Tie!");
                    lstBoxScores.Items.Add("Player Tie");
                    nudBet.Value = 0;
                    nudBet.Visible = true;
                    lblMoney.Text = ($"Money: ${Money}");
                }
                botSelection = 0;
                picPaper.BackColor = Color.Transparent;
                picScissors.BackColor = Color.Transparent;
                picRock.BackColor = Color.Transparent;
            }
        }
        private void tmrERPS_Tick(object sender, EventArgs e)
        {
            picCombination.Image = Paper_Scissors_Rock.Properties.Resources.Plus;
            randomEnemyMoveDisplayTick += 1;
            if (randomEnemyMoveDisplayTick == 10)
            {
                enemyMoveDisplayValue = enemyMoveDisplay.Next(1, 4);
                if (enemyMoveDisplayValue == 1)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources._5893958b8370b70e212f3e62;
                }
                else if (enemyMoveDisplayValue == 2)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources.Scissors;
                }
                else if (enemyMoveDisplayValue == 3)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources.Rock;
                }
            }
            if (randomEnemyMoveDisplayTick == 20)
            {
                enemyMoveDisplayValue = enemyMoveDisplay.Next(1, 4);
                if (enemyMoveDisplayValue == 1)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources._5893958b8370b70e212f3e62;
                }
                else if (enemyMoveDisplayValue == 2)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources.Scissors;
                }
                else if (enemyMoveDisplayValue == 3)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources.Rock;
                }
            }
            if (randomEnemyMoveDisplayTick == 30)
            {
                enemyMoveDisplayValue = enemyMoveDisplay.Next(1, 4);
                if (enemyMoveDisplayValue == 1)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources._5893958b8370b70e212f3e62;
                }
                else if (enemyMoveDisplayValue == 2)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources.Scissors;
                }
                else if (enemyMoveDisplayValue == 3)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources.Rock;
                }
            }
            if (randomEnemyMoveDisplayTick == 45)
            {
                botSelection = enemyTurn.Next(1, 4);
                if (botSelection == 1 && userSelection == 1)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources._5893958b8370b70e212f3e62;
                    tmrTiePaper.Start();
                    playerTie = true;
                    picPaper.BackColor = Color.Yellow;
                }
                else if (botSelection == 2 && userSelection == 2)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources.Scissors;
                    tmrTieScissors.Start();
                    playerTie = true;
                    picScissors.BackColor = Color.Yellow;
                }
                else if (botSelection == 3 && userSelection == 3)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources.Rock;
                    tmrTieRock.Start();
                    playerTie = true;
                    picRock.BackColor = Color.Yellow;
                }
                else if (botSelection == 2 && userSelection == 1)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources.Scissors;
                    tmrPaperScissors.Start();
                    playerWin = false;
                    picPaper.BackColor = Color.Yellow;
                }
                else if (botSelection == 3 && userSelection == 1)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources.Rock;
                    tmrRockPaper.Start();
                    playerWin = true;
                    picPaper.BackColor = Color.Yellow;
                }
                else if (botSelection == 1 && userSelection == 2)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources._5893958b8370b70e212f3e62;
                    tmrPaperScissors.Start();
                    playerWin = true;
                    picScissors.BackColor = Color.Yellow;
                }
                else if (botSelection == 1 && userSelection == 3)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources._5893958b8370b70e212f3e62;
                    tmrRockPaper.Start();
                    playerWin = false;
                    picRock.BackColor = Color.Yellow;
                }
                else if (botSelection == 2 && userSelection == 3)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources.Scissors;
                    tmrScissorsRock.Start();
                    playerWin = true;
                    picRock.BackColor = Color.Yellow;
                }
                else if (botSelection == 3 && userSelection == 2)
                {
                    picComputer.Image = Paper_Scissors_Rock.Properties.Resources.Rock;
                    tmrScissorsRock.Start();
                    playerWin = false;
                    picScissors.BackColor = Color.Yellow;
                }
                randomEnemyMoveDisplayTick = 0;
                tmrERPS.Stop();
            }
        }

        private void frmPaperScissorsRock_Load(object sender, EventArgs e)
        {
            lblMoney.Text = ($"Money: ${Money}");
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            frmInstructions formInstructions = new frmInstructions();
            formInstructions.ShowDialog();

        }

        private void nudBet_ValueChanged(object sender, EventArgs e)
        {
            betAmount = Convert.ToDouble(nudBet.Value);
        }
    }
}