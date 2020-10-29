using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblHello.Font = new Font("New Times Roman", 56);
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblHello.Font = new Font("New Times Roman", 9);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblHello.ForeColor = Color.Blue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblHello.ForeColor = Color.Green;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblHello.ForeColor = Color.Red;
        }

        private void LblHello_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblHello.Font = new Font("New Times Roman", 30, FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblHello.Font = new Font("New Times Roman", 30, FontStyle.Italic);
        }
    }
}
