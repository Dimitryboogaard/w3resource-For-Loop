using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intFactor1, intFactor2, intFactorMax, intGetal1, intGetal2, intMax;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intGetal1 = Convert.ToInt32(tbGetal1.Text);
            intGetal2 = Convert.ToInt32(tbGetal2.Text);
            intMax = Math.Max(intGetal1, intGetal2);

            for(intTeller = 1; intTeller <= intMax; intTeller++)
            { 
                if(intGetal1 % intTeller == 0)
                {
                    intFactor1 = intTeller;
                }
                if(intGetal2 % intTeller == 0)
                {
                    intFactor2 = intTeller;
                }
                if (intFactor1 == intFactor2)
                {
                    intFactorMax = intFactor1;
                }
            }

            tbUitkomst.Text = intFactorMax.ToString();
                 

        }
    }
}
