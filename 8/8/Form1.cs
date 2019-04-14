using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intSom, intInvoer, intOnevenTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt32(tbInvoer.Text);

            do
            {
                intTeller++;

                if (intTeller % 2 != 0)
                {
                    tbReeks.Text += intTeller.ToString() + " ";
                    intSom += intTeller;
                    intOnevenTeller++;
                }

            } while (intOnevenTeller < 10);

            tbSom.Text = intSom.ToString();
        }
    }
}
