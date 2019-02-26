using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTafels_Click(object sender, EventArgs e)
        {
            int cijfer1 = int.Parse(txbCijfer1.Text);
            int cijfer2 = int.Parse(txbCijfer2.Text);

            while (cijfer1 <= cijfer2)
            {
                int tafel = 1;
                while (tafel <= 10)
                {
                    txbTafels.Text = txbTafels.Text + tafel + " X " + cijfer1 + " = "
                            + (tafel * cijfer1) + "\r\n";
                    tafel = tafel + 1;
                }
                cijfer1 = cijfer1 + 1;
            }
        }
    }
}
