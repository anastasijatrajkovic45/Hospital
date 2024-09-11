namespace Bolnica.Forme
{
    partial class PregledStacionarnihPacijenata
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDodajOdeljenje = new System.Windows.Forms.Button();
            this.buttonObrisiOdeljenje = new System.Windows.Forms.Button();
            this.buttonIzmeniOdeljenje = new System.Windows.Forms.Button();
            this.pacijenti = new System.Windows.Forms.ListView();
            this.Mat_br = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime_pac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime_pac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum_prijema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum_otpusta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Odeljenje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Specijalista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pacijenti);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.groupBox1.Location = new System.Drawing.Point(29, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 405);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled pacijenata";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(555, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 156);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Odeljenje";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button6.Location = new System.Drawing.Point(6, 112);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 38);
            this.button6.TabIndex = 5;
            this.button6.Text = "Izmeni";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button5.Location = new System.Drawing.Point(6, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "Obrisi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button4.Location = new System.Drawing.Point(6, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 32);
            this.button4.TabIndex = 3;
            this.button4.Text = "Dodaj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDodajOdeljenje);
            this.groupBox2.Controls.Add(this.buttonObrisiOdeljenje);
            this.groupBox2.Controls.Add(this.buttonIzmeniOdeljenje);
            this.groupBox2.Location = new System.Drawing.Point(555, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 193);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stacionarni pacijenti";
            // 
            // buttonDodajOdeljenje
            // 
            this.buttonDodajOdeljenje.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonDodajOdeljenje.Location = new System.Drawing.Point(10, 52);
            this.buttonDodajOdeljenje.Name = "buttonDodajOdeljenje";
            this.buttonDodajOdeljenje.Size = new System.Drawing.Size(166, 40);
            this.buttonDodajOdeljenje.TabIndex = 1;
            this.buttonDodajOdeljenje.Text = "Dodaj pacijenta";
            this.buttonDodajOdeljenje.UseVisualStyleBackColor = true;
            this.buttonDodajOdeljenje.Click += new System.EventHandler(this.buttonDodajOdeljenje_Click);
            // 
            // buttonObrisiOdeljenje
            // 
            this.buttonObrisiOdeljenje.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonObrisiOdeljenje.Location = new System.Drawing.Point(6, 145);
            this.buttonObrisiOdeljenje.Name = "buttonObrisiOdeljenje";
            this.buttonObrisiOdeljenje.Size = new System.Drawing.Size(166, 42);
            this.buttonObrisiOdeljenje.TabIndex = 3;
            this.buttonObrisiOdeljenje.Text = "Obrisi pacijenta";
            this.buttonObrisiOdeljenje.UseVisualStyleBackColor = true;
            this.buttonObrisiOdeljenje.Click += new System.EventHandler(this.buttonObrisiOdeljenje_Click);
            // 
            // buttonIzmeniOdeljenje
            // 
            this.buttonIzmeniOdeljenje.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonIzmeniOdeljenje.Location = new System.Drawing.Point(6, 98);
            this.buttonIzmeniOdeljenje.Name = "buttonIzmeniOdeljenje";
            this.buttonIzmeniOdeljenje.Size = new System.Drawing.Size(166, 41);
            this.buttonIzmeniOdeljenje.TabIndex = 2;
            this.buttonIzmeniOdeljenje.Text = "Izmeni pacijenta";
            this.buttonIzmeniOdeljenje.UseVisualStyleBackColor = true;
            this.buttonIzmeniOdeljenje.Click += new System.EventHandler(this.buttonIzmeniOdeljenje_Click);
            // 
            // pacijenti
            // 
            this.pacijenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mat_br,
            this.Ime_pac,
            this.Prezime_pac,
            this.Datum_prijema,
            this.Datum_otpusta,
            this.Odeljenje,
            this.Specijalista});
            this.pacijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacijenti.HideSelection = false;
            this.pacijenti.Location = new System.Drawing.Point(0, 27);
            this.pacijenti.Name = "pacijenti";
            this.pacijenti.Size = new System.Drawing.Size(549, 356);
            this.pacijenti.TabIndex = 0;
            this.pacijenti.UseCompatibleStateImageBehavior = false;
            this.pacijenti.View = System.Windows.Forms.View.Details;
            // 
            // Mat_br
            // 
            this.Mat_br.Text = "Mat_br";
            this.Mat_br.Width = 75;
            // 
            // Ime_pac
            // 
            this.Ime_pac.Text = "Ime";
            this.Ime_pac.Width = 45;
            // 
            // Prezime_pac
            // 
            this.Prezime_pac.Text = "Prezime";
            this.Prezime_pac.Width = 82;
            // 
            // Datum_prijema
            // 
            this.Datum_prijema.Text = "DatumPrijema";
            this.Datum_prijema.Width = 98;
            // 
            // Datum_otpusta
            // 
            this.Datum_otpusta.Text = "DatumOtpusta";
            this.Datum_otpusta.Width = 133;
            // 
            // Odeljenje
            // 
            this.Odeljenje.Text = "Odeljenje";
            this.Odeljenje.Width = 91;
            // 
            // Specijalista
            // 
            this.Specijalista.Text = "Specijalista";
            // 
            // PregledStacionarnihPacijenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "PregledStacionarnihPacijenata";
            this.Text = "PregledStacionarnihPacijenata";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDodajOdeljenje;
        private System.Windows.Forms.Button buttonObrisiOdeljenje;
        private System.Windows.Forms.Button buttonIzmeniOdeljenje;
        private System.Windows.Forms.ListView pacijenti;
        private System.Windows.Forms.ColumnHeader Mat_br;
        private System.Windows.Forms.ColumnHeader Ime_pac;
        private System.Windows.Forms.ColumnHeader Prezime_pac;
        private System.Windows.Forms.ColumnHeader Datum_prijema;
        private System.Windows.Forms.ColumnHeader Datum_otpusta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader Odeljenje;
        private System.Windows.Forms.ColumnHeader Specijalista;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}