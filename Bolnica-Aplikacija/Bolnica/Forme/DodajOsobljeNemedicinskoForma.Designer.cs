namespace Bolnica.Forme
{
    partial class DodajOsobljeNemedicinskoForma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTipOdrzavanja = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbStruka = new System.Windows.Forms.TextBox();
            this.lblSpecijalnost = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTipOdrzavanja);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbStruka);
            this.groupBox1.Controls.Add(this.lblSpecijalnost);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(508, 357);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o nemedicinskom osoblju";
            // 
            // txtTipOdrzavanja
            // 
            this.txtTipOdrzavanja.Location = new System.Drawing.Point(163, 121);
            this.txtTipOdrzavanja.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipOdrzavanja.Name = "txtTipOdrzavanja";
            this.txtTipOdrzavanja.Size = new System.Drawing.Size(272, 29);
            this.txtTipOdrzavanja.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tip odrzavanja :";
            // 
            // txbStruka
            // 
            this.txbStruka.Location = new System.Drawing.Point(163, 158);
            this.txbStruka.Margin = new System.Windows.Forms.Padding(4);
            this.txbStruka.Name = "txbStruka";
            this.txbStruka.Size = new System.Drawing.Size(272, 29);
            this.txbStruka.TabIndex = 13;
            // 
            // lblSpecijalnost
            // 
            this.lblSpecijalnost.AutoSize = true;
            this.lblSpecijalnost.Location = new System.Drawing.Point(8, 161);
            this.lblSpecijalnost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecijalnost.Name = "lblSpecijalnost";
            this.lblSpecijalnost.Size = new System.Drawing.Size(72, 24);
            this.lblSpecijalnost.TabIndex = 12;
            this.lblSpecijalnost.Text = "Struka :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(364, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "DODAJ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(163, 84);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(272, 29);
            this.txtPrezime.TabIndex = 6;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(163, 47);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(272, 29);
            this.txtIme.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime :";
            // 
            // DodajOsobljeNemedicinskoForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 378);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodajOsobljeNemedicinskoForma";
            this.Text = "DodajOsobljeNemedicinskoForma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTipOdrzavanja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbStruka;
        private System.Windows.Forms.Label lblSpecijalnost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}