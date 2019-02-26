namespace Opdracht5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCijfer1 = new System.Windows.Forms.TextBox();
            this.txbCijfer2 = new System.Windows.Forms.TextBox();
            this.btnTafels = new System.Windows.Forms.Button();
            this.txbTafels = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cijfer 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cijfer 2";
            // 
            // txbCijfer1
            // 
            this.txbCijfer1.Location = new System.Drawing.Point(29, 45);
            this.txbCijfer1.Name = "txbCijfer1";
            this.txbCijfer1.Size = new System.Drawing.Size(62, 20);
            this.txbCijfer1.TabIndex = 2;
            // 
            // txbCijfer2
            // 
            this.txbCijfer2.Location = new System.Drawing.Point(134, 45);
            this.txbCijfer2.Name = "txbCijfer2";
            this.txbCijfer2.Size = new System.Drawing.Size(69, 20);
            this.txbCijfer2.TabIndex = 3;
            // 
            // btnTafels
            // 
            this.btnTafels.Location = new System.Drawing.Point(29, 71);
            this.btnTafels.Name = "btnTafels";
            this.btnTafels.Size = new System.Drawing.Size(84, 23);
            this.btnTafels.TabIndex = 4;
            this.btnTafels.Text = "Lekker tafelen";
            this.btnTafels.UseVisualStyleBackColor = true;
            this.btnTafels.Click += new System.EventHandler(this.btnTafels_Click);
            // 
            // txbTafels
            // 
            this.txbTafels.Location = new System.Drawing.Point(134, 74);
            this.txbTafels.Multiline = true;
            this.txbTafels.Name = "txbTafels";
            this.txbTafels.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbTafels.Size = new System.Drawing.Size(314, 411);
            this.txbTafels.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 497);
            this.Controls.Add(this.txbTafels);
            this.Controls.Add(this.btnTafels);
            this.Controls.Add(this.txbCijfer2);
            this.Controls.Add(this.txbCijfer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCijfer1;
        private System.Windows.Forms.TextBox txbCijfer2;
        private System.Windows.Forms.Button btnTafels;
        private System.Windows.Forms.TextBox txbTafels;
    }
}

