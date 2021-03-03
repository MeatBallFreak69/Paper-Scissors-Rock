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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.picCombination = new System.Windows.Forms.PictureBox();
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.picRock = new System.Windows.Forms.PictureBox();
            this.picScissors = new System.Windows.Forms.PictureBox();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.tmrPaperScissors = new System.Windows.Forms.Timer(this.components);
            this.tmrScissorsRock = new System.Windows.Forms.Timer(this.components);
            this.tmrRockPaper = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCombination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(84, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(619, 20);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Please select a move and the computer will play a random move against you ";
            this.lblInstructions.MouseHover += new System.EventHandler(this.lblInstructions_MouseHover);
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
            // tmrPaperScissors
            // 
            this.tmrPaperScissors.Tick += new System.EventHandler(this.tmrPaperScissors_Tick);
            // 
            // frmPaperScissorsRock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.picCombination);
            this.Controls.Add(this.picComputer);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.picRock);
            this.Controls.Add(this.picScissors);
            this.Controls.Add(this.picPaper);
            this.Name = "frmPaperScissorsRock";
            this.Text = "Paper Scissors Rock";
            this.MouseHover += new System.EventHandler(this.frmPaperScissorsRock_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.picCombination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.PictureBox picScissors;
        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.PictureBox picComputer;
        private System.Windows.Forms.PictureBox picCombination;
        private System.Windows.Forms.Timer tmrPaperScissors;
        private System.Windows.Forms.Timer tmrScissorsRock;
        private System.Windows.Forms.Timer tmrRockPaper;
    }
}

