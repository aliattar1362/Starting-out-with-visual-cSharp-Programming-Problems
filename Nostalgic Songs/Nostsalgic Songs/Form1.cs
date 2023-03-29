using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nostsalgic_Songs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void songButton_Click(object sender, EventArgs e)
        {
            labelControl.Text = "Summer of '69";
        }

        private void artistButton_Click(object sender, EventArgs e)
        {
            labelControl.Text = "Bryan Adams";
        }
    }
}
