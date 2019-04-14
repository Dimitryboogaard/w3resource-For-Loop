using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intDecimaal, intMacht, intQuotient;
        double dblMachtVanAcht, dblRest;
        string strOctaal;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intDecimaal = Convert.ToInt32(tbDecimaal.Text);
            dblRest = Convert.ToDouble(intDecimaal);
            

            while(dblMachtVanAcht <= intDecimaal)
            {
                dblMachtVanAcht += Math.Pow(8, intMacht);
                intMacht++;
            }


            intMacht = intMacht - 2;

            do
            {
                dblMachtVanAcht = Math.Pow(8, intMacht);
                intQuotient = Convert.ToInt16(Math.Floor(dblRest / dblMachtVanAcht));
                strOctaal += intQuotient.ToString();
                dblRest = dblRest % dblMachtVanAcht;
                intMacht--;
            } while (dblRest != 0); 

            tbOctaal.Text = strOctaal.ToString();

        }
    }
}
