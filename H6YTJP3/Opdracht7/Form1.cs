using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            int cijfer = int.Parse(txbCijfer.Text);
            int bereken = 1;
            int antwoord = 1;
            while(bereken < cijfer)
            {
                antwoord = antwoord * bereken;
                txbCalc.Text = txbCalc.Text + bereken + " X ";
                bereken = bereken + 1;
            }
            antwoord = antwoord * cijfer;
            txbCalc.Text = cijfer + "! = " + txbCalc.Text + cijfer + " = " + antwoord;
        }
    }
}
