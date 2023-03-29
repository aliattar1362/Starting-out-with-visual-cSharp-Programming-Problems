using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books_and_Authors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void goneWithTheWindButton_Click(object sender, EventArgs e)
        {
            label1.Visible = true; // Show the label 1
            label2.Visible = false;// Hide the label 2
            label3.Visible = false;// Hide the label 3
        }

        private void rootsButton_Click(object sender, EventArgs e)
        {
            label1.Visible = false;// Hide the label 1
            label2.Visible = true;// Show the label 2
            label3.Visible = false;// Hide the label 3
        }

        private void atlasShruggedButton_Click(object sender, EventArgs e)
        {
            label1.Visible = false;// Hide the label 1
            label2.Visible = false;// Hide the label 2
            label3.Visible = true;// Show the label 3
        }
    }
}
