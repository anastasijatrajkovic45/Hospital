namespace Bolnica.Forme
{
    partial class DodajSmenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSmena = new System.Windows.Forms.TextBox();
            this.buttonDodajSmenu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip smene:";
            // 
            // textBoxSmena
            // 
            this.textBoxSmena.Location = new System.Drawing.Point(156, 56);
            this.textBoxSmena.Name = "textBoxSmena";
            this.textBoxSmena.Size = new System.Drawing.Size(168, 29);
            this.textBoxSmena.TabIndex = 2;
            // 
            // buttonDodajSmenu
            // 
            this.buttonDodajSmenu.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonDodajSmenu.Location = new System.Drawing.Point(156, 130);
            this.buttonDodajSmenu.Name = "buttonDodajSmenu";
            this.buttonDodajSmenu.Size = new System.Drawing.Size(168, 41);
            this.buttonDodajSmenu.TabIndex = 3;
            this.buttonDodajSmenu.Text = "Dodaj smenu";
            this.buttonDodajSmenu.UseVisualStyleBackColor = true;
            this.buttonDodajSmenu.Click += new System.EventHandler(this.buttonDodajSmenu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonDodajSmenu);
            this.groupBox1.Controls.Add(this.textBoxSmena);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(55, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 288);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o smeni";
            // 
            // DodajSmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 375);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodajSmenu";
            this.Text = "DodajSmenu";
            this.Load += new System.EventHandler(this.DodajSmenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSmena;
        private System.Windows.Forms.Button buttonDodajSmenu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}