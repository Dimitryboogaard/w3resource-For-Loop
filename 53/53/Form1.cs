using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intStringLengte, intMacht, intQuotient;
        string strBinair, strDigit, strOctaal;
        double dblDecimaal, dblMachtVanAcht, dblRest;

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

            while(dblMachtVanAcht <= dblDecimaal)
            {
                dblMachtVanAcht = Math.Pow(8, intMacht);
                intMacht++;
            }

            dblRest = dblDecimaal;
            intMacht = intMacht - 2;

            do
            {
                dblMachtVanAcht = Math.Pow(8, intMacht);
                intQuotient = Convert.ToInt32(Math.Floor(dblRest / dblMachtVanAcht));
                strOctaal += intQuotient.ToString();
                dblRest = dblRest % dblMachtVanAcht;
                intMacht--;

            } while (dblRest != 0);

            tbOctaal.Text = strOctaal;
        }
    }
}
