using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _51
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intStringLengte, intDigit;
        string strOctaal;
        double dblDecimaal;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strOctaal = tbOctaal.Text;

            intStringLengte = strOctaal.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                intDigit = Convert.ToInt32(strOctaal.Substring(intStringLengte - intTeller - 1, 1));

                dblDecimaal += Math.Pow(8, intTeller) * intDigit;
            }

            tbDecimaal.Text = dblDecimaal.ToString();
        }
    }
}
