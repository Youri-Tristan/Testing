namespace Opdracht1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAantalKeer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbCijfer
            // 
            this.txbCijfer.AcceptsReturn = true;
            this.txbCijfer.Location = new System.Drawing.Point(93, 58);
            this.txbCijfer.Multiline = true;
            this.txbCijfer.Name = "txbCijfer";
            this.txbCijfer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbCijfer.Size = new System.Drawing.Size(167, 203);
            this.txbCijfer.TabIndex = 0;
            this.txbCijfer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tel knop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoelang moet ik gaan tellen?";
            // 
            // txbAantalKeer
            // 
            this.txbAantalKeer.Location = new System.Drawing.Point(160, 21);
            this.txbAantalKeer.Name = "txbAantalKeer";
            this.txbAantalKeer.Size = new System.Drawing.Size(100, 20);
            this.txbAantalKeer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 273);
            this.Controls.Add(this.txbAantalKeer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbCijfer);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCijfer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAantalKeer;
    }
}

