using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller;
        double dblSom, dblKwadraat;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 1; intTeller <= Convert.ToInt32(tbInvoer.Text); intTeller++)
            {
                dblKwadraat = Math.Pow(intTeller, 2);

                tbReeks.Text += dblKwadraat.ToString() + " ";

                dblSom += dblKwadraat;
            }

            tbSom.Text = dblSom.ToString();
        }
    }
}
