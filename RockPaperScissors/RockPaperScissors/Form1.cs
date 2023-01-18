using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int computerTurn = random.Next(1, 4);
            int playerTurn = random.Next(1, 4);

            switch (computerTurn)
            {
                case 1:
                    pictureBox1.ImageLocation = @"C:\Users\luhan\OneDrive\Desktop\portfolio\Rock.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox1.ImageLocation = @"C:\Users\luhan\OneDrive\Desktop\portfolio\Paper.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox1.ImageLocation = @"C:\Users\luhan\OneDrive\Desktop\portfolio\Scissors.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox1.ImageLocation = @"C:\Users\luhan\OneDrive\Desktop\portfolio\Rock.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
            //Assign picture to random number
            switch (playerTurn)
            {
                case 1:
                    pictureBox2.ImageLocation = @"C:\Users\luhan\OneDrive\Desktop\portfolio\Rock.jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox2.ImageLocation = @"C:\Users\luhan\OneDrive\Desktop\portfolio\Paper.jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox2.ImageLocation = @"C:\Users\luhan\OneDrive\Desktop\portfolio\Scissors.jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox2.ImageLocation = @"C:\Users\luhan\OneDrive\Desktop\portfolio\Rock.jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
            winner(computerTurn, playerTurn);

        }
            public void winner(int computerScore, int playerScore)
            {
            if (computerScore == 1 && playerScore == 2)
            {
                label1.Text = "You win!";
            }
            else if(computerScore == 1 && playerScore == 3)
            {
                label1.Text = "The Computer wins!";
            }
            else if (computerScore == 2 && playerScore == 1)
            {
                label1.Text = "The Computer wins!";
            }
            else if (computerScore == 2 && playerScore == 3)
            {
                label1.Text = "You win!";
            }
            else if (computerScore == 3 && playerScore == 1)
            {
                label1.Text = "You win!";
            }
            else if (computerScore == 2 && playerScore == 1)
            {
                label1.Text = "The Computer wins!";
            }
            else
            {
                label1.Text = "Tie!";
            }
        }        
    }
}
