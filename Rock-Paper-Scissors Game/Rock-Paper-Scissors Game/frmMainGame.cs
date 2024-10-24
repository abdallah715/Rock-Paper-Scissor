using Guna.UI2.WinForms;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_Game
{
    public partial class frmMainGame : Form
    {
        private enum enChoice
        {
            Rock = 0,
            Paper = 1,
            Scissors = 2
        }
        Random RandomNumber = new Random();
        List<Bitmap> ComputerImages;
        List<Bitmap> PlayerImages;
        enChoice PlayerChoice, ComputerChoice;
        private int TotalGameRounds,GameRound =1; 
        
        public frmMainGame(int GameRounds)
        {
            InitializeComponent();
            ComputerImages = new List<Bitmap>(new Bitmap[] { Properties.Resources.RightRockHandFreezed, Properties.Resources.PaperRight, Properties.Resources.ScissorRight });
            PlayerImages = new List<Bitmap>(new Bitmap[] { Properties.Resources.LeftRockHandFreezed, Properties.Resources.PaperLeft, Properties.Resources.ScissorLeft });
            TotalGameRounds = GameRounds+1;
           RestartGame();
        }
       
       
        private void RestartGame()
        {
            pbPlayer.Image = Properties.Resources.leftHandMoving;
            pbComputer.Image = Properties.Resources.RightHandMoving;
            lblGamestatus.Text = "Round " + GameRound.ToString();
            lblGamestatus.ForeColor = Color.Yellow;
            btnRock.Enabled = true;
            btnPaper.Enabled = true;
            btnScissors.Enabled = true;
            btnRock.Visible = true;
            btnPaper.Visible = true;
            btnScissors.Visible = true;
        }
        private void StopGame()
        {
            pbPlayer.Image = null;
            pbComputer.Image = null;
            btnRock.Enabled = false;
            btnPaper.Enabled = false;
            btnScissors.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            RestartGame();
        }

        private void RoundWinner()
        {

            if(PlayerChoice == ComputerChoice)
            {
                lblGamestatus.Text = "Drawing !";
                

            }
            else if ((PlayerChoice == enChoice.Rock && ComputerChoice == enChoice.Scissors) ||
             (PlayerChoice == enChoice.Paper && ComputerChoice == enChoice.Rock) ||
             (PlayerChoice == enChoice.Scissors && ComputerChoice == enChoice.Paper))
            {
                lblGamestatus.Text = "You win!";
                lblGamestatus.ForeColor= Color.Green;
                lblPlayerScore.Text = (int.Parse(lblPlayerScore.Text) + 1).ToString();
                GameRound++;
            }
            // Otherwise, the computer wins
            else
            {
                lblGamestatus.Text = "Computer wins!";
                lblGamestatus.ForeColor= Color.Red;
                lblComputerScore.Text = (int.Parse(lblComputerScore.Text) + 1).ToString();
                GameRound++;

            }
            

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            GameRound = 1;
            btnPlayAgain.Visible = false;
            lblPlayerScore.Text = Convert.ToString(0);
            lblComputerScore.Text = Convert.ToString(0);

            RestartGame();
        }

        private void GameWinner()
        {
            btnRock.Visible = false;
            btnPaper.Visible = false;
            btnScissors.Visible = false;

            if (int.Parse(lblPlayerScore.Text) > int.Parse(lblComputerScore.Text))
            {
                MessageBox.Show("Winner Winner Chicken Dinner , You Win !", "Rock-Paper-Scissor Game");
                lblGamestatus.Text = "You Win !";
               
            }
            else
            {
                MessageBox.Show("Computer Wins :-(", "Rock-Paper-Scissor Game");
                lblGamestatus.Text = "Computer Wins :-(";
            }
           
            btnPlayAgain.Visible= true;
        }
        private void PlayerButton_Click(object sender, EventArgs e)
        {
           
            StopGame();


            // Storing Choices
            PlayerChoice = (enChoice)Convert.ToByte((sender as Guna2Button).Tag.ToString());
            ComputerChoice = (enChoice)RandomNumber.Next(0,3);
            // Displaying Choices 
               //pbPlayer.BackgroundImage = PlayerImages[(byte)PlayerChoice];

            pbComputer.BackgroundImage = ComputerImages[(int)ComputerChoice];
            pbPlayer.BackgroundImage = PlayerImages[(int)PlayerChoice];

            RoundWinner();

            if(TotalGameRounds == GameRound)
            {
                GameWinner();
            }
            else
            {
                timer1.Start();
            }

        }
    }
}
