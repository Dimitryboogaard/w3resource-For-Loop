using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            tbSom.Text = Convert.ToString(Convert.ToInt16(tbGetal1.Text) + Convert.ToInt16(tbGetal2.Text) +
                                          Convert.ToInt16(tbGetal3.Text) + Convert.ToInt16(tbGetal4.Text) +
                                          Convert.ToInt16(tbGetal5.Text) + Convert.ToInt16(tbGetal6.Text) +
                                          Convert.ToInt16(tbGetal7.Text) + Convert.ToInt16(tbGetal8.Text) +
                                          Convert.ToInt16(tbGetal9.Text) + Convert.ToInt16(tbGetal10.Text));

            tbGemiddelde.Text = Convert.ToString(Convert.ToInt16(tbSom.Text) / 10);
        }
    }
}
