namespace Bolnica.Forme
{
    partial class PacijentiForma
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
            this.buttonStacionarni = new System.Windows.Forms.Button();
            this.buttonAmbulantni = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MatBr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonObrisiPacijenta = new System.Windows.Forms.Button();
            this.buttonDodajPacijenta = new System.Windows.Forms.Button();
            this.buttonIzmeniPacijenta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStacionarni
            // 
            this.buttonStacionarni.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonStacionarni.Location = new System.Drawing.Point(595, 137);
            this.buttonStacionarni.Name = "buttonStacionarni";
            this.buttonStacionarni.Size = new System.Drawing.Size(177, 68);
            this.buttonStacionarni.TabIndex = 0;
            this.buttonStacionarni.Text = "PREGLED STACIONARNIH PACIJENATA";
            this.buttonStacionarni.UseVisualStyleBackColor = true;
            this.buttonStacionarni.Click += new System.EventHandler(this.buttonStacionarni_Click);
            // 
            // buttonAmbulantni
            // 
            this.buttonAmbulantni.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonAmbulantni.Location = new System.Drawing.Point(595, 63);
            this.buttonAmbulantni.Name = "buttonAmbulantni";
            this.buttonAmbulantni.Size = new System.Drawing.Size(177, 68);
            this.buttonAmbulantni.TabIndex = 1;
            this.buttonAmbulantni.Text = "PREGLED AMBULANTNIH PACIJENATA";
            this.buttonAmbulantni.UseVisualStyleBackColor = true;
            this.buttonAmbulantni.Click += new System.EventHandler(this.buttonAmbulantni_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 384);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacijenti";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MatBr,
            this.Ime,
            this.Prezime});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(543, 350);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // buttonObrisiPacijenta
            // 
            this.buttonObrisiPacijenta.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonObrisiPacijenta.Location = new System.Drawing.Point(595, 357);
            this.buttonObrisiPacijenta.Name = "buttonObrisiPacijenta";
            this.buttonObrisiPacijenta.Size = new System.Drawing.Size(177, 54);
            this.buttonObrisiPacijenta.TabIndex = 6;
            this.buttonObrisiPacijenta.Text = "Obrisi pacijenta";
            this.buttonObrisiPacijenta.UseVisualStyleBackColor = true;
            // 
            // buttonDodajPacijenta
            // 
            this.buttonDodajPacijenta.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonDodajPacijenta.Location = new System.Drawing.Point(595, 220);
            this.buttonDodajPacijenta.Name = "buttonDodajPacijenta";
            this.buttonDodajPacijenta.Size = new System.Drawing.Size(177, 49);
            this.buttonDodajPacijenta.TabIndex = 4;
            this.buttonDodajPacijenta.Text = "Dodaj pacijenta";
            this.buttonDodajPacijenta.UseVisualStyleBackColor = true;
            this.buttonDodajPacijenta.Click += new System.EventHandler(this.buttonDodajPacijenta_Click);
            // 
            // buttonIzmeniPacijenta
            // 
            this.buttonIzmeniPacijenta.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonIzmeniPacijenta.Location = new System.Drawing.Point(595, 285);
            this.buttonIzmeniPacijenta.Name = "buttonIzmeniPacijenta";
            this.buttonIzmeniPacijenta.Size = new System.Drawing.Size(177, 53);
            this.buttonIzmeniPacijenta.TabIndex = 5;
            this.buttonIzmeniPacijenta.Text = "Izmeni pacijenta";
            this.buttonIzmeniPacijenta.UseVisualStyleBackColor = true;
            // 
            // PacijentiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonObrisiPacijenta);
            this.Controls.Add(this.buttonDodajPacijenta);
            this.Controls.Add(this.buttonIzmeniPacijenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAmbulantni);
            this.Controls.Add(this.buttonStacionarni);
            this.Name = "PacijentiForma";
            this.Text = "PacijentiForma";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStacionarni;
        private System.Windows.Forms.Button buttonAmbulantni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MatBr;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.Button buttonObrisiPacijenta;
        private System.Windows.Forms.Button buttonDodajPacijenta;
        private System.Windows.Forms.Button buttonIzmeniPacijenta;
    }
}