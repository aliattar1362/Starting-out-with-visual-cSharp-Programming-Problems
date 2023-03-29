using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            displayLabel.Text= "Eight of Diamonds.";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "Two of Clubs.";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "Ace of Spades.";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "Ten of Hearts.";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "Red Joker.";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
