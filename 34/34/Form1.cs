using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intVan, intTot, intPriemTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intVan = Convert.ToInt32(tbVan.Text);
            intTot = Convert.ToInt32(tbTot.Text);

            for(intTeller = intVan; intTeller <= intTot; intTeller++)
            {
                for(intTeller2 = 1; intTeller2 <= intTeller; intTeller2++)
                {
                    if(intTeller % intTeller2 == 0)
                    {
                        intPriemTeller++;
                    }
                }

                if(intPriemTeller == 2)
                {
                    tbReeks.Text += intTeller.ToString() + " ";
                }

                intPriemTeller = 0;
            }
        }
    }
}
