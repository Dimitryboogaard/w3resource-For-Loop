using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intStringLengte, intDigit, intTeller;
        string strGetal;
        double dblCube, dblSom;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strGetal = tbInvoer.Text;

            intStringLengte = strGetal.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                intDigit = Convert.ToInt32(strGetal.Substring(intTeller, 1));

                dblCube = Math.Pow(intDigit, 3);

                dblSom += dblCube;
            }

            if(dblSom == Convert.ToInt16(strGetal))
            {
                lblArmstrongOrNot.Text = "Armstrong";
            }
            else
            {
                lblArmstrongOrNot.Text = "Not Armstrong";
            }
        }
    }
}
