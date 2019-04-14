using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intSom;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 1; intTeller <= Convert.ToInt32(tbInvoer.Text) / 2; intTeller++)
            {
                if(Convert.ToInt32(tbInvoer.Text) % intTeller == 0)
                {
                    tbReeks.Text += intTeller.ToString() + " ";
                    intSom += intTeller;
                }
               
            }

            if (intSom == Convert.ToInt32(tbInvoer.Text))
            {
                lblPerfectOrNot.Text = "Perfect";
            }

            else
            {
                lblPerfectOrNot.Text = "Not perfect";
            }
        }
    }
}
