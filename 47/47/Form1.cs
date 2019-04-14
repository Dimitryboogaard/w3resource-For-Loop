using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strGetal;
        int intTeller, intTeller2, intStringLengte, intSom, intDigit, intFaculteit = 1;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strGetal = tbInvoer.Text;
            intStringLengte = strGetal.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                intDigit = Convert.ToInt32(strGetal.Substring(intTeller, 1));

                for(intTeller2 = 1; intTeller2 <= intDigit; intTeller2++)
                {
                    intFaculteit *= intTeller2;
                }

                intSom += intFaculteit;
                intFaculteit = 1;
            }

            if(intSom == Convert.ToInt32(strGetal))
            {
                lblStrongOrNot.Text = "Strong";
            }
            else
            {
                lblStrongOrNot.Text = "Not strong";
            }
        }
    }
}
