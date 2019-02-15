using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            try
            {
                double Vermogen = double.Parse(tbVermogen.Text);
                int Wielen = int.Parse(tbWielen.Text);
                double Gewicht = double.Parse(tbGewicht.Text);
                int CilinderInhoud = int.Parse(tbCilinderInhoud.Text);
                DateTime GeboorteDatum = dateTimePickerGeboorteDatum.Value;

                if(GeboorteDatum.AddYears(18) > DateTime.Now)
                {
                    MessageBox.Show("Je mag nog helemaal niet rijden op een motor!" +
                        " Je mag pas je A1 rijbewijs halen vanaf: " +
                        GeboorteDatum.AddYears(18).ToShortDateString());
                }
                else if(Wielen == 2)
                {
                    if(Vermogen <= 11 && CilinderInhoud <= 125)
                    {
                        if((Vermogen/Gewicht) <= 0.1)
                        {
                            MessageBox.Show("Je mag dit voertuig rijden met een A1 Rijbewijs.");
                        }
                        else if((Vermogen/Gewicht) <= 0.2)
                        {
                            MessageBox.Show("Je mag dit voertuig rijden met een A2 Rijbewijs. " +
                                "Die kan je verkrijgen als je 2 jaar je A1 heb.");
                        }
                        else
                        {
                            MessageBox.Show("Je mag dit voertuig rijden met een A3 Rijbewijs. " +
                                "Die kan je verkrijgen als je 2 jaar je A2 heb.");
                        }
                    }
                    else if(Vermogen <= 35 && CilinderInhoud <= 125)
                    {
                        if((Vermogen/Gewicht) <= 0.2)
                        {
                            MessageBox.Show("Je mag dit voertuig rijden met een A2 Rijbewijs.");
                        }
                        else
                        {
                            MessageBox.Show("Je mag dit voertuig rijden met een A3 Rijbewijs. " +
                                "Dit kan je verkrijgen als je al 2 jaar je A2 heb.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Je mag dit voertuig rijden met een A3 Rijbewijs.");
                    }
                }
                else if(Wielen == 3)
                {
                    if(Vermogen <= 15)
                    {
                        MessageBox.Show("Je kan dit voertuig rijden met een A1 Rijbewijs.");
                    }
                    else if(Vermogen > 15 && GeboorteDatum.AddYears(22) > DateTime.Now)
                    {
                        MessageBox.Show("Je mag dit voertuig pas rijden als je een" +
                            "A3 Rijbewijs heb. Die kan je pas halen vanaf: " + 
                            GeboorteDatum.AddYears(22).ToShortDateString() + " en als je al 2 jaar je A2 heb!");
                    }
                    else
                    {
                        MessageBox.Show("Je mag dit voertuig rijden met een A3 rijbewijs. " +
                            "Die kan je pas krijgen als je 2 jaar een A2 heb!");
                    }
                }
                else
                {
                    MessageBox.Show("Dit is geen motor... of kan je niet tellen?");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
