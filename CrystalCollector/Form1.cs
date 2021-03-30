using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalCollector
{
    public partial class Form1 : Form
    {
        public static Random random = new Random();
        public static int points = random.Next(100);
        public static int playerPoints = 0;
        public static int crystalOne = random.Next(1, 10);
        public static int crystalTwo = random.Next(1, 10);
        public static int crystalThree = random.Next(1, 10);
        public static int crystalFour = random.Next(1, 10);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = points.ToString();
            label5.Text = playerPoints.ToString();
            crystalOne = random.Next(1, 10);
            crystalTwo = random.Next(1, 10);
            crystalThree = random.Next(1, 10);
            crystalFour = random.Next(1, 10);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            playerPoints += crystalOne;
            winLose();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            playerPoints += crystalTwo;
            winLose();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            playerPoints += crystalThree;
            winLose();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            playerPoints += crystalFour;

            winLose();
        }

        private void winLose()
        {
            label5.Text = playerPoints.ToString();
            if (playerPoints > points)
            {
                MessageBox.Show("You Lose!", "Loser", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                playerPoints = 0;
                points = random.Next(100);
                label3.Text = points.ToString();
                label5.Text = playerPoints.ToString();
                crystalOne = random.Next(1, 10);
                crystalTwo = random.Next(1, 10);
                crystalThree = random.Next(1, 10);
                crystalFour = random.Next(1, 10);
            }
            else if (playerPoints == points)
            {
                MessageBox.Show("You Win!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                playerPoints = 0;
                points = random.Next(100);
                label3.Text = points.ToString();
                label5.Text = playerPoints.ToString();
                crystalOne = random.Next(1, 10);
                crystalTwo = random.Next(1, 10);
                crystalThree = random.Next(1, 10);
                crystalFour = random.Next(1, 10);

            }


        }

    }
}
