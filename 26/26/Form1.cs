using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intSom;
        string strEnen;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 1; intTeller <= Convert.ToInt32(tbInvoer.Text); intTeller++)
            {
                strEnen += "1";
                intSom += Convert.ToInt32(strEnen);
                tbReeks.Text += strEnen + " ";
            }

            tbSom.Text = intSom.ToString();
        }
    }
}
