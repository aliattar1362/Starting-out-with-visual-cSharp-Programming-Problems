using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Head_or_Tails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void headButton_Click(object sender, EventArgs e)
        {
            headPictureBox.Visible = true;
            tailPictureBox.Visible = false;
        }

        private void tailButton_Click(object sender, EventArgs e)
        {
            tailPictureBox.Visible = true;
            headPictureBox.Visible = false;
        }
    }
}
