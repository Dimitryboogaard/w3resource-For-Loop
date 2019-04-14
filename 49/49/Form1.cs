using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intStart, intAantal, intVerschil, intTeller, intSom, intGetal;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intStart = Convert.ToInt32(tbStart.Text);
            intAantal = Convert.ToInt32(tbAantal.Text);
            intVerschil = Convert.ToInt32(tbVerschil.Text);

            for(intTeller = 0; intTeller < intAantal; intTeller++)
            {
                intGetal = intStart + intTeller * intVerschil;
                intSom += intGetal;
            }

            tbSom.Text = intSom.ToString();
        }
    }
}
