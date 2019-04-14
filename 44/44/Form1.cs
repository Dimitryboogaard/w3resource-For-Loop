using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intGetal1, intGetal2, intFactor1, intFactor2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intGetal1 = Convert.ToInt32(tbGetal1.Text);
            intGetal2 = Convert.ToInt32(tbGetal2.Text);

            do
            {
                intTeller++;
                intFactor1 = intTeller * intGetal1;

                do
                {
                    intTeller2++;
                    intFactor2 = intTeller2 * intGetal2;
                } while (intFactor2 < intFactor1);

                if (intFactor1 != intFactor2)
                {
                    intTeller2 = 0;
                }
            } while (intFactor1 != intFactor2);

            tbLCM.Text = intFactor1.ToString();
        }
    }
}
