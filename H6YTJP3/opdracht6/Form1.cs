using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            double cijfer = double.Parse(txbCijfer.Text);
            double power = double.Parse(txbPower.Text);
            double start = 0;
            while(start <= power)
            {               
                txbCalc.Text = txbCalc.Text + cijfer + "^" + start +
                    " = " + Math.Pow(cijfer, start) + "\r\n";
                start = start + 1;
            }
        }
    }
}
