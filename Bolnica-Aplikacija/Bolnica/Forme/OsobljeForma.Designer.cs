namespace Bolnica.Forme
{
    partial class OsobljeForma
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
            this.buttonNemedicinsko = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonMedicinsko = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 281);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled osoblja";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonNemedicinsko);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(224, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 152);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nemedicinsko osoblje";
            // 
            // buttonNemedicinsko
            // 
            this.buttonNemedicinsko.Location = new System.Drawing.Point(18, 46);
            this.buttonNemedicinsko.Name = "buttonNemedicinsko";
            this.buttonNemedicinsko.Size = new System.Drawing.Size(163, 81);
            this.buttonNemedicinsko.TabIndex = 0;
            this.buttonNemedicinsko.Text = "PREGLED NEMEDICINSKOG OSOBLJA";
            this.buttonNemedicinsko.UseVisualStyleBackColor = true;
            this.buttonNemedicinsko.Click += new System.EventHandler(this.buttonNemedicinsko_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonMedicinsko);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(15, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 152);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medicinsko osoblje";
            // 
            // buttonMedicinsko
            // 
            this.buttonMedicinsko.Location = new System.Drawing.Point(15, 46);
            this.buttonMedicinsko.Name = "buttonMedicinsko";
            this.buttonMedicinsko.Size = new System.Drawing.Size(151, 81);
            this.buttonMedicinsko.TabIndex = 0;
            this.buttonMedicinsko.Text = "PREGLED MEDICINSKOG OSOBLJA";
            this.buttonMedicinsko.UseVisualStyleBackColor = true;
            this.buttonMedicinsko.Click += new System.EventHandler(this.buttonMedicinsko_Click);
            // 
            // OsobljeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "OsobljeForma";
            this.Text = "OsobljeForma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonNemedicinsko;
        private System.Windows.Forms.Button buttonMedicinsko;
    }
}