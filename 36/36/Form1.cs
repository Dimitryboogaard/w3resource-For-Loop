using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intTeller3 = 2, intTeller4, intInvoer;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt32(tbInvoer.Text);

            intTeller4 = intInvoer - 1;

            for (intTeller2 = 1; intTeller2 <= intInvoer; intTeller2++)
            {
                rtUitvoer.Text += " ";
            }
           
            rtUitvoer.Text += "1";
            rtUitvoer.Text += Environment.NewLine;

            for (intTeller = 1; intTeller < intInvoer; intTeller++)
            {
                for(intTeller2 = 1; intTeller2 <= intTeller4; intTeller2++)
                {
                    rtUitvoer.Text += " ";
                }

                for (intTeller2 = 1; intTeller2 <= intTeller3; intTeller2++)
                {
                    rtUitvoer.Text += intTeller2.ToString();
                }

                for (intTeller2 = intTeller3 - 1; intTeller2 > 0; intTeller2--)
                {
                    rtUitvoer.Text += intTeller2.ToString();
                }

                intTeller3++;
                intTeller4--;

                rtUitvoer.Text += Environment.NewLine;
            }
        }
    }
}
