using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intStringLengte, intLengte;
        string strInvoer;
        bool booPalindrome = true;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringLengte = strInvoer.Length;
            if(intStringLengte % 2 != 0)
            {
                intLengte = (intStringLengte - 1) / 2;
            }

            else
            {
                intLengte = intStringLengte / 2;
            }

            for(intTeller = 0; intTeller < intLengte; intTeller++)
            {
                if(strInvoer.Substring(intTeller, 1) != strInvoer.Substring(intStringLengte - intTeller -1, 1))
                {
                    booPalindrome = false;
                }
            }

            if(booPalindrome)
            {
                lblPalindromeOrNot.Text = "Palindrome";
            }
            else
            {
                lblPalindromeOrNot.Text = "Not palindrome";
            }
        }
    }
}
