using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _54
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intStringLengte, intDigit, intMacht, intQuotient;
        string strOctaal, strBinair;
        double dblDecimaal, dblMachtVanTwee, dblRest;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strOctaal = tbOctaal.Text;
            intStringLengte = strOctaal.Length;
            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                intDigit = Convert.ToInt32(strOctaal.Substring(intStringLengte - intTeller - 1, 1));
                dblDecimaal += Math.Pow(8, intTeller) * intDigit;
            }

            while(dblMachtVanTwee <= dblDecimaal)
            {
                dblMachtVanTwee = Math.Pow(2, intMacht);
                intMacht++;
            }

            dblRest = dblDecimaal;
            intMacht = intMacht - 2;
            
            do
            {
                dblMachtVanTwee = Math.Pow(2, intMacht);
                intQuotient = Convert.ToInt32(Math.Floor(dblRest / dblMachtVanTwee));
                strBinair += intQuotient.ToString();
                dblRest = dblRest % dblMachtVanTwee;
                intMacht--;
            } while (dblRest != 0);

            tbBinair.Text = strBinair.ToString();
        }
    }
}
