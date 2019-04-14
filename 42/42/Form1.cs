using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strBinair, strDigit;
        int intTeller, intUitvoer, intStringLengte;
        double dblWaarde;
        

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strBinair = tbInvoer.Text;

            intStringLengte = strBinair.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                strDigit = strBinair.Substring(intStringLengte - intTeller - 1, 1);
                if(strDigit == "1")
                {
                    dblWaarde += Math.Pow(2, intTeller);
                }
            }

            tbUitvoer.Text = dblWaarde.ToString();
        }
    }
}
