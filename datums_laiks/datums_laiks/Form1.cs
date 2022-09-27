using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datums_laiks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime theDate;
            theDate = DateTime.Now;
            MessageBox.Show(theDate.ToString());
            File.AppendAllText("datums,laiks.txt", "\nDatums: " + theDate);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string info = File.ReadAllText("datums,laiks.txt");
            MessageBox.Show("---------- Tagad piejama info: -------------\n" + info);
        }
    }
}
