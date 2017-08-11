using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thermometer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int degF = 100 - vScrollBar1.Value;
            double degC = (5.0 / 9.0) * (degF - 32.0);
            lblF.Text = degF.ToString();
            lblC.Text = Convert.ToInt16(degC).ToString();
        }
    }
}
