using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _55
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intMacht, intDecimaal, intQuotient;
        double dblMachtVan16, dblRest;
        string strHex;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intDecimaal = Convert.ToInt32(tbDecimaal.Text);

            while(dblMachtVan16 <= intDecimaal)
            {
                dblMachtVan16 = Math.Pow(16, intMacht);
                intMacht++;
            }

            intMacht = intMacht - 2;
            dblRest = intDecimaal;

            do
            {
                dblMachtVan16 = Math.Pow(16, intMacht);
                intQuotient = Convert.ToInt32(Math.Floor(dblRest / dblMachtVan16));

                if (intQuotient < 10)
                {
                    strHex += intQuotient.ToString();
                }

                else if (intQuotient == 10)
                {
                    strHex += "A";
                }

                else if (intQuotient == 11)
                {
                    strHex += "B";
                }

                else if (intQuotient == 12)
                {
                    strHex += "C";
                }

                else if(intQuotient == 13)
                {
                    strHex += "D";
                }

                else if(intQuotient == 14)
                {
                    strHex += "E";
                }

                else if(intQuotient == 15)
                {
                    strHex += "F";
                }

                dblRest = dblRest % dblMachtVan16;
                intMacht--;
            } while (dblRest != 0);

            tbHex.Text = strHex;
        }
    }
}
