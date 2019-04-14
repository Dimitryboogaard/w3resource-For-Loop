using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intSom;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 100; intTeller <= 200; intTeller++)
            {
                if(intTeller % 9 == 0)
                {
                    tbReeks.Text += intTeller.ToString() + " ";
                    intSom += intTeller;
                }
            }

            tbSom.Text = intSom.ToString();
        }
    }
}
