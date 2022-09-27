using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace balts_melns
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

        private void buttonBalts_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void buttonMelns_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void buttonZals_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void buttonZils_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void buttonSarkans_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void buttonViolets_Click(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.Violet;
            this.label2.ForeColor = Color.Violet;
        }

        private void buttonRoza_Click(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.Pink;
            this.label2.ForeColor = Color.Pink;
        }

        private void buttonBruns_Click(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.Brown;
            this.label2.ForeColor = Color.Brown;
        }

        private void buttonDzeltens_Click(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.Yellow;
            this.label2.ForeColor = Color.Yellow;
        }

        private void buttonPeleks_Click(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.Gray;
            this.label2.ForeColor = Color.Gray;
        }
    }
}
