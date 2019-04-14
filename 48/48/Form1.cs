using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intTeller3, intSom, intFaculteit = 1, intStringLengte, intDigit, intVan, intTot;
        string strGetal;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intVan = Convert.ToInt32(tbVan.Text);
            intTot = Convert.ToInt32(tbTot.Text);

            for(intTeller = intVan; intTeller <= intTot; intTeller++)
            {
                strGetal = Convert.ToString(intTeller);

                intStringLengte = strGetal.Length;

                for(intTeller2 = 0; intTeller2 < intStringLengte; intTeller2++)
                {
                    intDigit = Convert.ToInt32(strGetal.Substring(intTeller2, 1));

                    for(intTeller3 = 1; intTeller3 <= intDigit; intTeller3++)
                    {
                        intFaculteit *= intTeller3;
                    }

                    intSom += intFaculteit;
                    intFaculteit = 1;
                }

                if(intSom == intTeller)
                {
                    tbReeks.Text += intSom.ToString() + " ";
                }

                intSom = 0;

            }
        }
    }
}
