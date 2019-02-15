namespace Opdracht_8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbVermogen = new System.Windows.Forms.TextBox();
            this.tbWielen = new System.Windows.Forms.TextBox();
            this.tbGewicht = new System.Windows.Forms.TextBox();
            this.tbCilinderInhoud = new System.Windows.Forms.TextBox();
            this.dateTimePickerGeboorteDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbVermogen
            // 
            this.tbVermogen.Location = new System.Drawing.Point(122, 30);
            this.tbVermogen.Name = "tbVermogen";
            this.tbVermogen.Size = new System.Drawing.Size(100, 20);
            this.tbVermogen.TabIndex = 0;
            // 
            // tbWielen
            // 
            this.tbWielen.Location = new System.Drawing.Point(122, 68);
            this.tbWielen.Name = "tbWielen";
            this.tbWielen.Size = new System.Drawing.Size(100, 20);
            this.tbWielen.TabIndex = 1;
            // 
            // tbGewicht
            // 
            this.tbGewicht.Location = new System.Drawing.Point(122, 107);
            this.tbGewicht.Name = "tbGewicht";
            this.tbGewicht.Size = new System.Drawing.Size(100, 20);
            this.tbGewicht.TabIndex = 2;
            // 
            // tbCilinderInhoud
            // 
            this.tbCilinderInhoud.Location = new System.Drawing.Point(122, 148);
            this.tbCilinderInhoud.Name = "tbCilinderInhoud";
            this.tbCilinderInhoud.Size = new System.Drawing.Size(100, 20);
            this.tbCilinderInhoud.TabIndex = 3;
            // 
            // dateTimePickerGeboorteDatum
            // 
            this.dateTimePickerGeboorteDatum.Location = new System.Drawing.Point(122, 188);
            this.dateTimePickerGeboorteDatum.Name = "dateTimePickerGeboorteDatum";
            this.dateTimePickerGeboorteDatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerGeboorteDatum.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "GeboorteDatum: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cilinderinhoud: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gewicht: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Aantal Wielen: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vermogen: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "kW";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "kG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "CC";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(330, 27);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 13;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 233);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerGeboorteDatum);
            this.Controls.Add(this.tbCilinderInhoud);
            this.Controls.Add(this.tbGewicht);
            this.Controls.Add(this.tbWielen);
            this.Controls.Add(this.tbVermogen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVermogen;
        private System.Windows.Forms.TextBox tbWielen;
        private System.Windows.Forms.TextBox tbGewicht;
        private System.Windows.Forms.TextBox tbCilinderInhoud;
        private System.Windows.Forms.DateTimePicker dateTimePickerGeboorteDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBereken;
    }
}

