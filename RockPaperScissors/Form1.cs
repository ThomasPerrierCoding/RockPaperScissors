using System;
using System.Windows.Forms;

/*
 *      In the game Rock Paper Scissors, two players 
 *      simultaneously choose one of three options: 
 *      rock, paper, or scissors.
 *      
 *      If both players choose the same option, then
 *      the result is a tie.
 *      
 *      However, if they choose differently, the winner
 *      is determined as follows:
 *      
 *      •	Rock beats scissors, because a rock can break 
 *          a pair of scissors. 
 *          
 *      •	Scissors beats paper, because scissors can cut 
 *          paper. 
 *          
 *      •	Paper beats rock, because a piece of paper can 
 *          cover a rock. 
 *          
 *      Create a game in which the computer randomly chooses 
 *      rock, paper, or scissors. Let the user enter a character, 
 *      r, p, or s, each representing one of the three choices. 
 *      
 *      Then, determine the winner. Save the application as 
 *      RockPaperScissors.
 */

namespace RockPaperScissors
{
    public partial class FormRockPapeerSccissors : Form
    {
        int ties = 0;
        int wins = 0;
        int loses = 0;

        public FormRockPapeerSccissors()
        {
            InitializeComponent();
        }

        private void buttonResetAll_Click(object sender, EventArgs e)
        {
            txtChoice.Text = "";
            txtComp.Text = "";
            txtWin.Text = "";
            txtUserWin.Text = "";
            txtCompWin.Text = "";
            txtTie.Text = "";
            buttonCalculate.Enabled = false;
            wins = 0;
            ties = 0;
            loses = 0;
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Exit Application?", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Random randm = new Random();
            string choice = "";
            int comp_Choice = randm.Next(1, 3);
            int user_Choice = 0;

            choice = txtChoice.Text;

            if(choice=="Rock")
            {
                user_Choice = 1;
            }
            else if(choice=="Paper")
            {
                user_Choice = 2;
            }
            else
            {
                user_Choice = 3;
            }

            if (comp_Choice == 1)
            {
                txtComp.Text = "Rock";
            }
            else if (comp_Choice == 2)
            {
                txtComp.Text = "Paper";
            }
            else if(comp_Choice == 3)
            {
                txtComp.Text = "Scissors";
            }

            if(user_Choice==1 && comp_Choice==2 || user_Choice == 2 && comp_Choice == 3 || user_Choice == 3 && comp_Choice == 1)
            {
                loses++;
                txtWin.Text = "Computer";
            }
            else if(user_Choice==1 && comp_Choice==3 || user_Choice == 2 && comp_Choice == 1 || user_Choice == 3 && comp_Choice == 2)
            {
                wins++;
                txtWin.Text = "User";

            }
            else if(user_Choice==comp_Choice)
            {
                ties++;
                txtWin.Text = "Tie";
            }

            txtCompWin.Text = loses.ToString();
            txtUserWin.Text = wins.ToString();
            txtTie.Text = ties.ToString();

            comp_Choice = randm.Next(1, 3);

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtChoice.Text = "";
            txtComp.Text = "";
            txtWin.Text = "";
            buttonCalculate.Enabled = false;
        }

        private void txtChoice_TextChanged(object sender, EventArgs e)
        {
            buttonCalculate.Enabled = true;
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            txtChoice.Text = "Scissors";
            txtWin.Text = "";
            txtComp.Text = "";
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            txtChoice.Text = "Paper";
            txtWin.Text = "";
            txtComp.Text = "";
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            txtChoice.Text = "Rock";
            txtWin.Text = "";
            txtComp.Text = "";
        }
    }
}
