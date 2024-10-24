namespace Rock_Paper_Scissors_Game
{
    partial class frmMainGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainGame));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScissors = new Guna.UI2.WinForms.Guna2Button();
            this.btnPaper = new Guna.UI2.WinForms.Guna2Button();
            this.btnRock = new Guna.UI2.WinForms.Guna2Button();
            this.pbComputer = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblGamestatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPlayAgain = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(307, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(816, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Computer";
            // 
            // btnScissors
            // 
            this.btnScissors.BorderRadius = 30;
            this.btnScissors.CheckedState.Parent = this.btnScissors;
            this.btnScissors.CustomImages.Parent = this.btnScissors;
            this.btnScissors.FillColor = System.Drawing.Color.Snow;
            this.btnScissors.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissors.ForeColor = System.Drawing.Color.Black;
            this.btnScissors.HoverState.Parent = this.btnScissors;
            this.btnScissors.Location = new System.Drawing.Point(820, 529);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.ShadowDecoration.Parent = this.btnScissors;
            this.btnScissors.Size = new System.Drawing.Size(227, 61);
            this.btnScissors.TabIndex = 6;
            this.btnScissors.Tag = "2";
            this.btnScissors.Text = "Scissors";
            this.btnScissors.Click += new System.EventHandler(this.PlayerButton_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BorderRadius = 30;
            this.btnPaper.CheckedState.Parent = this.btnPaper;
            this.btnPaper.CustomImages.Parent = this.btnPaper;
            this.btnPaper.FillColor = System.Drawing.Color.Snow;
            this.btnPaper.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.ForeColor = System.Drawing.Color.Black;
            this.btnPaper.HoverState.Parent = this.btnPaper;
            this.btnPaper.Location = new System.Drawing.Point(545, 529);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.ShadowDecoration.Parent = this.btnPaper;
            this.btnPaper.Size = new System.Drawing.Size(227, 61);
            this.btnPaper.TabIndex = 7;
            this.btnPaper.Tag = "1";
            this.btnPaper.Text = "Papar";
            this.btnPaper.Click += new System.EventHandler(this.PlayerButton_Click);
            // 
            // btnRock
            // 
            this.btnRock.BorderRadius = 30;
            this.btnRock.CheckedState.Parent = this.btnRock;
            this.btnRock.CustomImages.Parent = this.btnRock;
            this.btnRock.FillColor = System.Drawing.Color.White;
            this.btnRock.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.ForeColor = System.Drawing.Color.Black;
            this.btnRock.HoverState.Parent = this.btnRock;
            this.btnRock.Location = new System.Drawing.Point(256, 529);
            this.btnRock.Name = "btnRock";
            this.btnRock.ShadowDecoration.Parent = this.btnRock;
            this.btnRock.Size = new System.Drawing.Size(227, 61);
            this.btnRock.TabIndex = 8;
            this.btnRock.Tag = "0";
            this.btnRock.Text = "Rock";
            this.btnRock.Click += new System.EventHandler(this.PlayerButton_Click);
            // 
            // pbComputer
            // 
            this.pbComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbComputer.Image = global::Rock_Paper_Scissors_Game.Properties.Resources.RightRockHandFreezed;
            this.pbComputer.Location = new System.Drawing.Point(761, 169);
            this.pbComputer.Name = "pbComputer";
            this.pbComputer.Size = new System.Drawing.Size(315, 300);
            this.pbComputer.TabIndex = 1;
            this.pbComputer.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayer.Image = global::Rock_Paper_Scissors_Game.Properties.Resources.LeftRockHandFreezed;
            this.pbPlayer.Location = new System.Drawing.Point(233, 169);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(315, 300);
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1141, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Score";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.Green;
            this.lblPlayerScore.Location = new System.Drawing.Point(82, 219);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(31, 32);
            this.lblPlayerScore.TabIndex = 11;
            this.lblPlayerScore.Text = "0";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScore.ForeColor = System.Drawing.Color.Red;
            this.lblComputerScore.Location = new System.Drawing.Point(1166, 219);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(31, 32);
            this.lblComputerScore.TabIndex = 12;
            this.lblComputerScore.Text = "0";
            // 
            // lblGamestatus
            // 
            this.lblGamestatus.AutoSize = true;
            this.lblGamestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamestatus.ForeColor = System.Drawing.Color.Yellow;
            this.lblGamestatus.Location = new System.Drawing.Point(528, 23);
            this.lblGamestatus.Name = "lblGamestatus";
            this.lblGamestatus.Size = new System.Drawing.Size(178, 46);
            this.lblGamestatus.TabIndex = 13;
            this.lblGamestatus.Text = "Round 1";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BorderRadius = 30;
            this.btnPlayAgain.CheckedState.Parent = this.btnPlayAgain;
            this.btnPlayAgain.CustomImages.Parent = this.btnPlayAgain;
            this.btnPlayAgain.FillColor = System.Drawing.Color.Red;
            this.btnPlayAgain.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.Black;
            this.btnPlayAgain.HoverState.Parent = this.btnPlayAgain;
            this.btnPlayAgain.Location = new System.Drawing.Point(545, 529);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.ShadowDecoration.Parent = this.btnPlayAgain;
            this.btnPlayAgain.Size = new System.Drawing.Size(227, 61);
            this.btnPlayAgain.TabIndex = 14;
            this.btnPlayAgain.Tag = "1";
            this.btnPlayAgain.Text = "Play Again ?";
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // frmMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1294, 699);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblGamestatus);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbComputer);
            this.Controls.Add(this.pbPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                                     Rock-Paper-Scissors ";
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbComputer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnScissors;
        private Guna.UI2.WinForms.Guna2Button btnPaper;
        private Guna.UI2.WinForms.Guna2Button btnRock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label lblGamestatus;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnPlayAgain;
    }
}

