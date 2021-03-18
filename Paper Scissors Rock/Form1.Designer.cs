namespace Paper_Scissors_Rock
{
    partial class frmPaperScissorsRock
    {
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
            this.lblComputer = new System.Windows.Forms.Label();
            this.tmrPaperScissors = new System.Windows.Forms.Timer(this.components);
            this.tmrScissorsRock = new System.Windows.Forms.Timer(this.components);
            this.tmrRockPaper = new System.Windows.Forms.Timer(this.components);
            this.tmrTiePaper = new System.Windows.Forms.Timer(this.components);
            this.tmrTieScissors = new System.Windows.Forms.Timer(this.components);
            this.tmrTieRock = new System.Windows.Forms.Timer(this.components);
            this.picCombination = new System.Windows.Forms.PictureBox();
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.picRock = new System.Windows.Forms.PictureBox();
            this.picScissors = new System.Windows.Forms.PictureBox();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.tmrERPS = new System.Windows.Forms.Timer(this.components);
            this.lstBoxScores = new System.Windows.Forms.ListBox();
            this.lblScoreBoard = new System.Windows.Forms.Label();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picCombination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.Location = new System.Drawing.Point(338, 479);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(87, 20);
            this.lblComputer.TabIndex = 4;
            this.lblComputer.Text = "Computer";
            this.lblComputer.MouseHover += new System.EventHandler(this.lblComputer_MouseHover);
            // 
            // tmrPaperScissors
            // 
            this.tmrPaperScissors.Tick += new System.EventHandler(this.tmrPaperScissors_Tick);
            // 
            // tmrScissorsRock
            // 
            this.tmrScissorsRock.Tick += new System.EventHandler(this.tmrScissorsRock_Tick);
            // 
            // tmrRockPaper
            // 
            this.tmrRockPaper.Tick += new System.EventHandler(this.tmrRockPaper_Tick);
            // 
            // tmrTiePaper
            // 
            this.tmrTiePaper.Tick += new System.EventHandler(this.tmrTiePaper_Tick);
            // 
            // tmrTieScissors
            // 
            this.tmrTieScissors.Tick += new System.EventHandler(this.tmrTieScissors_Tick);
            // 
            // tmrTieRock
            // 
            this.tmrTieRock.Tick += new System.EventHandler(this.tmrTieRock_Tick);
            // 
            // picCombination
            // 
            this.picCombination.Image = global::Paper_Scissors_Rock.Properties.Resources.Plus;
            this.picCombination.Location = new System.Drawing.Point(298, 188);
            this.picCombination.Name = "picCombination";
            this.picCombination.Size = new System.Drawing.Size(169, 141);
            this.picCombination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCombination.TabIndex = 6;
            this.picCombination.TabStop = false;
            this.picCombination.MouseHover += new System.EventHandler(this.picCombination_MouseHover);
            // 
            // picComputer
            // 
            this.picComputer.Image = global::Paper_Scissors_Rock.Properties.Resources.question_Mark;
            this.picComputer.Location = new System.Drawing.Point(298, 335);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(169, 141);
            this.picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picComputer.TabIndex = 5;
            this.picComputer.TabStop = false;
            this.picComputer.MouseHover += new System.EventHandler(this.picComputer_MouseHover);
            // 
            // picRock
            // 
            this.picRock.Image = global::Paper_Scissors_Rock.Properties.Resources.Rock;
            this.picRock.Location = new System.Drawing.Point(473, 41);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(169, 141);
            this.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRock.TabIndex = 2;
            this.picRock.TabStop = false;
            this.picRock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picRock_MouseDown);
            this.picRock.MouseHover += new System.EventHandler(this.picRock_MouseHover);
            // 
            // picScissors
            // 
            this.picScissors.Image = global::Paper_Scissors_Rock.Properties.Resources.Scissors;
            this.picScissors.Location = new System.Drawing.Point(298, 41);
            this.picScissors.Name = "picScissors";
            this.picScissors.Size = new System.Drawing.Size(169, 141);
            this.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picScissors.TabIndex = 1;
            this.picScissors.TabStop = false;
            this.picScissors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picScissors_MouseDown);
            this.picScissors.MouseHover += new System.EventHandler(this.picScissors_MouseHover);
            // 
            // picPaper
            // 
            this.picPaper.Image = global::Paper_Scissors_Rock.Properties.Resources._5893958b8370b70e212f3e62;
            this.picPaper.Location = new System.Drawing.Point(123, 41);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(169, 141);
            this.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPaper.TabIndex = 0;
            this.picPaper.TabStop = false;
            this.picPaper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPaper_MouseDown);
            this.picPaper.MouseHover += new System.EventHandler(this.picPaper_MouseHover);
            // 
            // tmrERPS
            // 
            this.tmrERPS.Tick += new System.EventHandler(this.tmrERPS_Tick);
            // 
            // lstBoxScores
            // 
            this.lstBoxScores.FormattingEnabled = true;
            this.lstBoxScores.Location = new System.Drawing.Point(657, 281);
            this.lstBoxScores.Name = "lstBoxScores";
            this.lstBoxScores.Size = new System.Drawing.Size(131, 212);
            this.lstBoxScores.TabIndex = 7;
            // 
            // lblScoreBoard
            // 
            this.lblScoreBoard.AutoSize = true;
            this.lblScoreBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreBoard.Location = new System.Drawing.Point(681, 265);
            this.lblScoreBoard.Name = "lblScoreBoard";
            this.lblScoreBoard.Size = new System.Drawing.Size(77, 13);
            this.lblScoreBoard.TabIndex = 8;
            this.lblScoreBoard.Text = "Score Board";
            // 
            // btnInstructions
            // 
            this.btnInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.Location = new System.Drawing.Point(283, 12);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(201, 23);
            this.btnInstructions.TabIndex = 9;
            this.btnInstructions.Text = "Show Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(12, 212);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(54, 16);
            this.lblMoney.TabIndex = 10;
            this.lblMoney.Text = "Money";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 232);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // frmPaperScissorsRock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.lblScoreBoard);
            this.Controls.Add(this.lstBoxScores);
            this.Controls.Add(this.picCombination);
            this.Controls.Add(this.picComputer);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.picRock);
            this.Controls.Add(this.picScissors);
            this.Controls.Add(this.picPaper);
            this.Name = "frmPaperScissorsRock";
            this.Text = "Paper Scissors Rock";
            this.Load += new System.EventHandler(this.frmPaperScissorsRock_Load);
            this.MouseHover += new System.EventHandler(this.frmPaperScissorsRock_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.picCombination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.PictureBox picScissors;
        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.PictureBox picComputer;
        private System.Windows.Forms.PictureBox picCombination;
        private System.Windows.Forms.Timer tmrPaperScissors;
        private System.Windows.Forms.Timer tmrScissorsRock;
        private System.Windows.Forms.Timer tmrRockPaper;
        private System.Windows.Forms.Timer tmrTiePaper;
        private System.Windows.Forms.Timer tmrTieScissors;
        private System.Windows.Forms.Timer tmrTieRock;
        private System.Windows.Forms.Timer tmrERPS;
        private System.Windows.Forms.ListBox lstBoxScores;
        private System.Windows.Forms.Label lblScoreBoard;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

