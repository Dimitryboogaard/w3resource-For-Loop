using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intTeller3, intTeller4 = 4;

        private void button1_Click(object sender, EventArgs e)
        {
            for(intTeller = 1; intTeller <= 4; intTeller++)
            {
                for(intTeller3 = 1; intTeller3 <= intTeller4; intTeller3++)
                {
                    rtUitvoer.Text += " ";
                }

                intTeller4--;

                for(intTeller2 = 1; intTeller2 <= intTeller; intTeller2++)
                {
                    rtUitvoer.Text += "* ";
                }

                rtUitvoer.Text += Environment.NewLine;
            }
        }
    }
}
