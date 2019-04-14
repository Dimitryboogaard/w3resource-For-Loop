using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intTeller3 = 4, intTeller4 = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            for(intTeller = 1; intTeller <= 5; intTeller++)
            {
                for(intTeller2 = 1; intTeller2 <= intTeller3; intTeller2++)
                {
                    rtUitvoer.Text += " ";
                }
                intTeller3 -= 1;

                for(intTeller2 = 1; intTeller2 <= intTeller4; intTeller2++)
                {
                    rtUitvoer.Text += "*";
                }

                intTeller4 += 2;

                rtUitvoer.Text += Environment.NewLine;
            }

            intTeller3 = 1;
            intTeller4 -= 2;

            for(intTeller = 1; intTeller <= 4; intTeller++)
            {
                for(intTeller2 = 1; intTeller2 <= intTeller3; intTeller2++)
                {
                    rtUitvoer.Text += " ";
                }

                intTeller3 += 1;
                intTeller4 -= 2;

                for(intTeller2 = 1; intTeller2 <= intTeller4; intTeller2++)
                {
                    rtUitvoer.Text += "*";
                }

                rtUitvoer.Text += Environment.NewLine;
            }
        }
    }
}
