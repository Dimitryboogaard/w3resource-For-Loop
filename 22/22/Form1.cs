using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2;
        string str01 = "0";

        private void button1_Click(object sender, EventArgs e)
        {
            for(intTeller = 1; intTeller <= 4; intTeller++)
            {
                for(intTeller2 = 1; intTeller2 <= intTeller; intTeller2++)
                {
                    if(str01 == "1")
                    {
                        str01 = "0";
                    }
                    else if(str01 == "0")
                    {
                        str01 = "1";
                    }
                    rtUitvoer.Text += str01;

                }

                rtUitvoer.Text += Environment.NewLine;
            }
        }
    }
}
