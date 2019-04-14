using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 1; intTeller <= 4; intTeller++)
            {
                for(intTeller2 = 1; intTeller2 <= intTeller; intTeller2++)
                {
                    rtUitvoer.Text += intTeller.ToString();
                }
                rtUitvoer.Text += Environment.NewLine;
            }
        }
    }
}
