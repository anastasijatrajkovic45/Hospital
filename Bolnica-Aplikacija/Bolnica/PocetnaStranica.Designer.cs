namespace Bolnica
{
    partial class PocetnaStranica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaStranica));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOsoblje = new System.Windows.Forms.Button();
            this.btnPacijenti = new System.Windows.Forms.Button();
            this.btnOdeljenja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOLNICA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Location = new System.Drawing.Point(34, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnOsoblje
            // 
            this.btnOsoblje.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOsoblje.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold);
            this.btnOsoblje.Location = new System.Drawing.Point(440, 127);
            this.btnOsoblje.Name = "btnOsoblje";
            this.btnOsoblje.Size = new System.Drawing.Size(212, 51);
            this.btnOsoblje.TabIndex = 2;
            this.btnOsoblje.Text = "OSOBLJE";
            this.btnOsoblje.UseVisualStyleBackColor = false;
            this.btnOsoblje.Click += new System.EventHandler(this.btnOsoblje_Click);
            // 
            // btnPacijenti
            // 
            this.btnPacijenti.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPacijenti.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold);
            this.btnPacijenti.Location = new System.Drawing.Point(440, 205);
            this.btnPacijenti.Name = "btnPacijenti";
            this.btnPacijenti.Size = new System.Drawing.Size(212, 51);
            this.btnPacijenti.TabIndex = 3;
            this.btnPacijenti.Text = "PACIJENTI";
            this.btnPacijenti.UseVisualStyleBackColor = false;
            this.btnPacijenti.Click += new System.EventHandler(this.btnPacijenti_Click);
            // 
            // btnOdeljenja
            // 
            this.btnOdeljenja.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOdeljenja.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold);
            this.btnOdeljenja.Location = new System.Drawing.Point(440, 286);
            this.btnOdeljenja.Name = "btnOdeljenja";
            this.btnOdeljenja.Size = new System.Drawing.Size(212, 51);
            this.btnOdeljenja.TabIndex = 4;
            this.btnOdeljenja.Text = "ODELJENJA";
            this.btnOdeljenja.UseVisualStyleBackColor = false;
            this.btnOdeljenja.Click += new System.EventHandler(this.btnOdeljenja_Click);
            // 
            // PocetnaStranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(703, 641);
            this.Controls.Add(this.btnOdeljenja);
            this.Controls.Add(this.btnPacijenti);
            this.Controls.Add(this.btnOsoblje);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "PocetnaStranica";
            this.Text = "PocetnaStranica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOsoblje;
        private System.Windows.Forms.Button btnPacijenti;
        private System.Windows.Forms.Button btnOdeljenja;
    }
}