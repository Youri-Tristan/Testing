using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tafel = 1;
            int cijfer = int.Parse(txbCijfer.Text);
            while(tafel <= 10)
            {
                txbTafel.Text = txbTafel.Text + tafel + " X " + cijfer + " = "
                    + (tafel * cijfer) + "\r\n";
                tafel = tafel + 1;
            }
        }
    }
}
