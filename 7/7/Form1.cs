using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intInvoer;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt32(tbInvoer.Text);

            for (intTeller2 = 1; intTeller2 <= 10; intTeller2++)
            {
                for (intTeller = 1; intTeller <= intInvoer; intTeller++)
                {
                    rtUitvoer.Text += intTeller.ToString() + " x " + intTeller2.ToString() +
                                      " = " + Convert.ToString(intTeller2 * intTeller);

                    if(intTeller < intInvoer)
                    {
                        rtUitvoer.Text += ", ";
                    }
                }

                rtUitvoer.Text += Environment.NewLine;
            }
        }
    }
}
