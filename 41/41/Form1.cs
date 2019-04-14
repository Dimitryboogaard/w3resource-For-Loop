using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intInvoer;
        string strUitvoer;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt16(tbInvoer.Text);
            strUitvoer = Convert.ToString(intInvoer, 2);
            tbUitvoer.Text = strUitvoer;
        }
    }
}
