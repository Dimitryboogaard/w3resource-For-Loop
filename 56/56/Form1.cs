using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intTeller3, intTeller4, intInvoer, intPriemTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt32(tbInvoer.Text);

            for(intTeller = 1; intTeller <= intInvoer; intTeller++)
            {
                intPriemTeller = 0;
                for(intTeller2 = 1; intTeller2 <= intTeller; intTeller2++)
                {
                    if(intTeller % intTeller2 == 0)
                    {
                        intPriemTeller++;
                    }
                }

                if(intPriemTeller == 2)
                {
                    
                    for(intTeller3 = 1; intTeller3 <= intInvoer; intTeller3++)
                    {
                        intPriemTeller = 0;                        for(intTeller4 = 1; intTeller4 <= intTeller3; intTeller4++)
                        {
                            if(intTeller3 % intTeller4 == 0)
                            {
                                intPriemTeller++;
                            }
                        }

                        if(intPriemTeller == 2 && intTeller + intTeller3 == intInvoer)
                        {
                            intPriemTeller = 0;
                            rtUitvoer.Text += intInvoer.ToString() + " = " + intTeller.ToString() +
                                              " + " + intTeller3.ToString() + Environment.NewLine;
                        }
                    }
                }
            }
        }
    }
}
