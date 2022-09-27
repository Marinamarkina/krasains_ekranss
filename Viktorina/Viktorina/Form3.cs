using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viktorina
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {  
            if (Form2.punkti == 1) labRezultats.Text = Form2.punkti + " punkts";
            else labRezultats.Text = Form2.punkti + " punkti";

            switch (Form2.punkti)
            {
                case 10:
                    labKoment.Text = "\nTu esi īsts savas zemes patriots! Turklāt vēl ar lieliskām zināšanām. Apsveicam! Tu atbildēji pareizi uz visiem jautājumiem!";
                    break;
                case 9:
                    labKoment.Text = "\nAtbildes liecina, ka pazīsti Latviju, bet tev vēl ir fakti ko atklāt!";
                    break;
                case 8:
                    labKoment.Text = "\nAtbildes liecina, ka pazīsti Latviju, bet tev vēl ir fakti ko atklāt!";
                    break;
                case 7:
                    labKoment.Text = "\nAtbildes liecina, ka pazīsti Latviju, bet tev vēl ir fakti ko atklāt!";
                    break;
                case 6:
                    labKoment.Text = "\nAtbildes liecina, ka pazīsti Latviju, bet tev vēl ir fakti ko atklāt!";
                    break;
                default:
                    labKoment.Text = "Spriežot pēc atbildēm, zināšanas par Latviju tev ir jāpapildina! Diemžēl liela daļa tavu atbilžu bija nepareizas.";
                    break;
            }
          
        }
    }
}
