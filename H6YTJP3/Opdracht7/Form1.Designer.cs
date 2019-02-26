namespace Opdracht7
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
            this.txbCalc = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbCijfer
            // 
            this.txbCijfer.Location = new System.Drawing.Point(93, 22);
            this.txbCijfer.Name = "txbCijfer";
            this.txbCijfer.Size = new System.Drawing.Size(100, 20);
            this.txbCijfer.TabIndex = 0;
            // 
            // txbCalc
            // 
            this.txbCalc.Location = new System.Drawing.Point(93, 59);
            this.txbCalc.Multiline = true;
            this.txbCalc.Name = "txbCalc";
            this.txbCalc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbCalc.Size = new System.Drawing.Size(172, 324);
            this.txbCalc.TabIndex = 1;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(12, 59);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "button1";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 406);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txbCalc);
            this.Controls.Add(this.txbCijfer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCijfer;
        private System.Windows.Forms.TextBox txbCalc;
        private System.Windows.Forms.Button btnBereken;
    }
}

