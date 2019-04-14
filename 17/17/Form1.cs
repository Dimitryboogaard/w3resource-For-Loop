using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intTeller3 = 4;

        private void tbAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 1; intTeller <= 4; intTeller++)
            {
                for(intTeller2 = 1; intTeller2 <= intTeller3; intTeller2++)
                {
                    rtUitvoer.Text += " ";
                }

                intTeller3--;

                for(intTeller2 = 1; intTeller2 <= intTeller; intTeller2++)
                {
                    rtUitvoer.Text += intTeller.ToString();
                }

                rtUitvoer.Text += Environment.NewLine;
            }
        }
    }
}
