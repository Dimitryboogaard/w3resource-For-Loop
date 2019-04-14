using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intPriemTeller, intInvoer;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt32(tbInvoer.Text);
            for(intTeller = 1; intTeller <= intInvoer; intTeller++)
            {
                if(intInvoer % intTeller == 0)
                {
                    intPriemTeller++;
                }
            }

            if(intPriemTeller == 2)
            {
                lblPriemOfNiet.Text = "Priem";
            }
            else
            {
                lblPriemOfNiet.Text = "Niet priem";
            }

            intPriemTeller = 0;
        }
    }
}
