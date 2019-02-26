namespace opdracht6
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
            this.txbCijfer = new System.Windows.Forms.TextBox();
            this.txbPower = new System.Windows.Forms.TextBox();
            this.txbCalc = new System.Windows.Forms.TextBox();
            this.btnPower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbCijfer
            // 
            this.txbCijfer.Location = new System.Drawing.Point(17, 12);
            this.txbCijfer.Name = "txbCijfer";
            this.txbCijfer.Size = new System.Drawing.Size(100, 20);
            this.txbCijfer.TabIndex = 0;
            // 
            // txbPower
            // 
            this.txbPower.Location = new System.Drawing.Point(123, 12);
            this.txbPower.Name = "txbPower";
            this.txbPower.Size = new System.Drawing.Size(100, 20);
            this.txbPower.TabIndex = 1;
            // 
            // txbCalc
            // 
            this.txbCalc.Location = new System.Drawing.Point(123, 50);
            this.txbCalc.Multiline = true;
            this.txbCalc.Name = "txbCalc";
            this.txbCalc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbCalc.Size = new System.Drawing.Size(100, 261);
            this.txbCalc.TabIndex = 2;
            this.txbCalc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(17, 50);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(75, 23);
            this.btnPower.TabIndex = 3;
            this.btnPower.Text = "button1";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.txbCalc);
            this.Controls.Add(this.txbPower);
            this.Controls.Add(this.txbCijfer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCijfer;
        private System.Windows.Forms.TextBox txbPower;
        private System.Windows.Forms.TextBox txbCalc;
        private System.Windows.Forms.Button btnPower;
    }
}

