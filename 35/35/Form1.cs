using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intGetal1 = 0, intGetal2 = 1, intGetal3, intInvoer;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt32(tbInvoer.Text);

            tbFibonacciReeks.Text += "0 1 ";

            for(intTeller = 1; intTeller <= intInvoer - 2; intTeller++)
            {
                intGetal3 = intGetal1 + intGetal2;
                intGetal1 = intGetal2;
                intGetal2 = intGetal3;

                tbFibonacciReeks.Text += intGetal3.ToString() + " ";
            }
        }
    }
}
