namespace Bolnica.Forme
{
    partial class PregledPacijenataZaLekara
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
            this.pacijenti = new System.Windows.Forms.GroupBox();
            this.pacijenti1 = new System.Windows.Forms.ListView();
            this.MatBr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonObrisiOdeljenje = new System.Windows.Forms.Button();
            this.buttonDodajOdeljenje = new System.Windows.Forms.Button();
            this.buttonIzmeniOdeljenje = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pacijenti.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pacijenti
            // 
            this.pacijenti.Controls.Add(this.pacijenti1);
            this.pacijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.pacijenti.Location = new System.Drawing.Point(25, 27);
            this.pacijenti.Name = "pacijenti";
            this.pacijenti.Size = new System.Drawing.Size(376, 384);
            this.pacijenti.TabIndex = 3;
            this.pacijenti.TabStop = false;
            this.pacijenti.Text = "Pacijenti";
            // 
            // pacijenti1
            // 
            this.pacijenti1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MatBr,
            this.Ime,
            this.Prezime});
            this.pacijenti1.HideSelection = false;
            this.pacijenti1.Location = new System.Drawing.Point(7, 28);
            this.pacijenti1.Name = "pacijenti1";
            this.pacijenti1.Size = new System.Drawing.Size(342, 350);
            this.pacijenti1.TabIndex = 0;
            this.pacijenti1.UseCompatibleStateImageBehavior = false;
            this.pacijenti1.View = System.Windows.Forms.View.Details;
            // 
            // MatBr
            // 
            this.MatBr.Text = "MatBr";
            this.MatBr.Width = 89;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 115;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 133;
            // 
            // buttonObrisiOdeljenje
            // 
            this.buttonObrisiOdeljenje.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonObrisiOdeljenje.Location = new System.Drawing.Point(6, 123);
            this.buttonObrisiOdeljenje.Name = "buttonObrisiOdeljenje";
            this.buttonObrisiOdeljenje.Size = new System.Drawing.Size(177, 32);
            this.buttonObrisiOdeljenje.TabIndex = 9;
            this.buttonObrisiOdeljenje.Text = "Obrisi pacijenta";
            this.buttonObrisiOdeljenje.UseVisualStyleBackColor = true;
            // 
            // buttonDodajOdeljenje
            // 
            this.buttonDodajOdeljenje.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonDodajOdeljenje.Location = new System.Drawing.Point(6, 21);
            this.buttonDodajOdeljenje.Name = "buttonDodajOdeljenje";
            this.buttonDodajOdeljenje.Size = new System.Drawing.Size(177, 32);
            this.buttonDodajOdeljenje.TabIndex = 7;
            this.buttonDodajOdeljenje.Text = "Dodaj pacijenta";
            this.buttonDodajOdeljenje.UseVisualStyleBackColor = true;
            this.buttonDodajOdeljenje.Click += new System.EventHandler(this.buttonDodajOdeljenje_Click);
            // 
            // buttonIzmeniOdeljenje
            // 
            this.buttonIzmeniOdeljenje.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonIzmeniOdeljenje.Location = new System.Drawing.Point(6, 70);
            this.buttonIzmeniOdeljenje.Name = "buttonIzmeniOdeljenje";
            this.buttonIzmeniOdeljenje.Size = new System.Drawing.Size(177, 35);
            this.buttonIzmeniOdeljenje.TabIndex = 8;
            this.buttonIzmeniOdeljenje.Text = "Izmeni pacijenta";
            this.buttonIzmeniOdeljenje.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDodajOdeljenje);
            this.groupBox2.Controls.Add(this.buttonObrisiOdeljenje);
            this.groupBox2.Controls.Add(this.buttonIzmeniOdeljenje);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.groupBox2.Location = new System.Drawing.Point(421, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 169);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ambulantni";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.groupBox3.Location = new System.Drawing.Point(421, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 174);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stacionarni";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dodaj pacijenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.Location = new System.Drawing.Point(6, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "Obrisi pacijenta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button3.Location = new System.Drawing.Point(6, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Izmeni pacijenta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PregledPacijenataZaLekara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pacijenti);
            this.Name = "PregledPacijenataZaLekara";
            this.Text = "PregledPacijenataZaLekara";
            this.Load += new System.EventHandler(this.PregledPacijenataZaLekara_Load);
            this.pacijenti.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pacijenti;
        private System.Windows.Forms.ListView pacijenti1;
        private System.Windows.Forms.ColumnHeader MatBr;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.Button buttonObrisiOdeljenje;
        private System.Windows.Forms.Button buttonDodajOdeljenje;
        private System.Windows.Forms.Button buttonIzmeniOdeljenje;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}