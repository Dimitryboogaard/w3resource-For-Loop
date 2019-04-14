using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _46
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strBinair, strDigit;
        int intTeller, intStringLengte;
        double dblDecimaal;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strBinair = tbBinair.Text;

            intStringLengte = strBinair.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                strDigit = strBinair.Substring(intStringLengte - intTeller - 1, 1);
                
                    if(strDigit == "1")
                    {
                        dblDecimaal += Math.Pow(2, intTeller);
                    }
                
            }

            tbDecimaal.Text = dblDecimaal.ToString();
        }
    }
}
