using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intSom, intGetal1, intGetal2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intGetal1 = Convert.ToInt16(tbGetal1.Text);
            intGetal2 = Convert.ToInt16(tbGetal2.Text);

            for(intTeller = intGetal1; intTeller <= intGetal2; intTeller++)
            {
                for(intTeller2 = 1; intTeller2 <= intTeller / 2; intTeller2++)
                {
                    if(intTeller % intTeller2 == 0)
                    {
                        intSom += intTeller2;
                    }
                }

                if(intSom == intTeller)
                {
                    tbPerfectNumbers.Text += intTeller.ToString() + " ";
                }

                intSom = 0;
            }
        }
    }
}
