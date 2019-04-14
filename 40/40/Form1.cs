using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intMax = 66;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {



            rtUitvoer.Text += "A";
            rtUitvoer.Text += Environment.NewLine;

            for(intTeller = 1; intTeller < 4; intTeller++)
            {
                for(intTeller2 = 65; intTeller2 <= intMax; intTeller2++)
                {
                    char karakter = Convert.ToChar(intTeller2);
                    rtUitvoer.Text += karakter.ToString() + " ";
                }

                for(intTeller2 = intMax - 1; intTeller2 >= 65; intTeller2--)
                {
                    char karakter = Convert.ToChar(intTeller2);
                    rtUitvoer.Text += karakter.ToString() + " ";
                }

                intMax++;

                rtUitvoer.Text += Environment.NewLine;

            }
        }
    }
}
