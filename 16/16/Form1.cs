using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intSom, intInvoer;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt32(tbInvoer.Text);

            do
            {
                intTeller++;

                if (intTeller % 2 == 0)
                {
                    tbReeks.Text += intTeller.ToString() + " ";
                    intTeller2++;
                    intSom += intTeller;
                }
            } while (intTeller2 < intInvoer);

            tbSom.Text = intSom.ToString();
        }
    }
}
