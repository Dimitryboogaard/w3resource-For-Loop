﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 1; intTeller <= 10; intTeller++)
            {
                rtUitvoer.Text += Convert.ToString(intTeller) + " x " + tbInvoer.Text + " = " +
                                  Convert.ToString(intTeller * Convert.ToInt32(tbInvoer.Text)) +
                                  Environment.NewLine;
            }
        }
    }
}
