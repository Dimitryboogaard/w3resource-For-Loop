using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intNegens;
        string strNegens;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 1; intTeller <= Convert.ToInt32(tbInvoer.Text); intTeller++)
            {
                strNegens += "9";
            }

            for(intTeller = 1; intTeller <= Convert.ToInt32(tbInvoer.Text); intTeller++)
            {
               intNegens += Convert.ToInt32(strNegens.Substring(0, intTeller));
            }

            lblAntwoord.Text = Convert.ToString(intNegens);
        }
    }
}
