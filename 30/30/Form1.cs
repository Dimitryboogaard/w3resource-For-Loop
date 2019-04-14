using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intVan, intTot;
        string strCijfer;
        double dblDigit, dblSom, dblCube;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intVan = Convert.ToInt16(tbVan.Text);
            intTot = Convert.ToInt16(tbTot.Text);

            for(intTeller = intVan; intTeller <= intTot; intTeller++)
            {
                strCijfer = Convert.ToString(intTeller);

                for(intTeller2 = 0; intTeller2 < strCijfer.Length; intTeller2++)
                {
                    dblDigit = Convert.ToInt16(strCijfer.Substring(intTeller2, 1));
                    dblCube = Math.Pow(dblDigit, 3);
                    dblSom += dblCube;
                }

                if(dblSom == intTeller)
                {
                    tbReeks.Text += dblSom.ToString() + " ";
                }

                dblSom = 0;
            }
        }
    }
}
