using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clickable_Number_Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onePictureBox_Click(object sender, EventArgs e)
        {
            oneLabel.Visible = true; // Show "One" in label one.
            twoLabel.Visible = false; // Hide "Two" in label two.
            threeLabel.Visible = false; // Hide "Three" in label three.
            fourLabel.Visible = false; // Hide "Four" in label four.
            fiveLabel.Visible = false; // Hide "Five" in label five.
        }

        private void twoPictureBox_Click(object sender, EventArgs e)
        {
            oneLabel.Visible = false; // Hide "One" in label one.
            twoLabel.Visible = true; // Show "Two" in label two.
            threeLabel.Visible = false; // Hide "Three" in label three.
            fourLabel.Visible = false; // Hide "Four" in label four.
            fiveLabel.Visible = false; // Hide "Five" in label five.
        }

        private void threePictureBox_Click(object sender, EventArgs e)
        {
            oneLabel.Visible = false; // Hide "One" in label one.
            twoLabel.Visible = false; // Hide "Two" in label two.
            threeLabel.Visible = true; // Show "Three" in label three.
            fourLabel.Visible = false; // Hide "Four" in label four.
            fiveLabel.Visible = false; // Hide "Five" in label five.
        }

        private void fourPictureBox_Click(object sender, EventArgs e)
        {
            oneLabel.Visible = false; // Hide "One" in label one.
            twoLabel.Visible = false; // Hide "Two" in label two.
            threeLabel.Visible = false; // Hide "Three" in label three.
            fourLabel.Visible = true; // Show "Four" in label four.
            fiveLabel.Visible = false; // Hide "Five" in label five.
        }

        private void fivePictureBox_Click(object sender, EventArgs e)
        {
            oneLabel.Visible = false; // Hide "One" in label one.
            twoLabel.Visible = false; // Hide "Two" in label two.
            threeLabel.Visible = false; // Hide "Three" in label three.
            fourLabel.Visible = false; // Hide "Four" in label four.
            fiveLabel.Visible = true; // Show "Five" in label five.
        }
    }
}
