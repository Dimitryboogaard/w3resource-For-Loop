using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2 = 3, intTeller3, intTeller4 = 1;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for (intTeller3 = 1; intTeller3 <= 3; intTeller3++)
            {

                for (intTeller = 1; intTeller <= intTeller2; intTeller++)
                {
                    rtUitvoer.Text += " ";
                }

                intTeller2 = intTeller2 - 2;

                for (intTeller = 1; intTeller <= intTeller4; intTeller++)
                {
                    rtUitvoer.Text += "*";
                }

                intTeller4 = intTeller4 + 2;

                rtUitvoer.Text += Environment.NewLine;
            }
        }
    }
}
