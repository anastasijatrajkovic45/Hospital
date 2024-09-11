namespace Bolnica
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
            this.cmdRead = new System.Windows.Forms.Button();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.cmdManyToOne = new System.Windows.Forms.Button();
            this.cmdOneToMany = new System.Windows.Forms.Button();
            this.cmdReadSmena = new System.Windows.Forms.Button();
            this.cmdCreateSmena = new System.Windows.Forms.Button();
            this.cmdManyToOneOdeljenje = new System.Windows.Forms.Button();
            this.cmdOneToManyOdeljenje = new System.Windows.Forms.Button();
            this.cmdCreateStomatoloskaStolica = new System.Windows.Forms.Button();
            this.cmdTPCMedicinsko = new System.Windows.Forms.Button();
            this.cmdTPCNemedicinsko = new System.Windows.Forms.Button();
            this.cmdCreateMedicinsko = new System.Windows.Forms.Button();
            this.cmdCreateNemedicinsko = new System.Windows.Forms.Button();
            this.cmdTPCHPacijent = new System.Windows.Forms.Button();
            this.cmdCreateSubclassPacijent = new System.Windows.Forms.Button();
            this.cmdGetPacijent = new System.Windows.Forms.Button();
            this.cmdManyToOnePacijent = new System.Windows.Forms.Button();
            this.cmdOneToManyPacijent = new System.Windows.Forms.Button();
            this.cmdManyToOneStacionarni = new System.Windows.Forms.Button();
            this.cmdOneToManyStacionarni = new System.Windows.Forms.Button();
            this.cmdCreatePacijenta = new System.Windows.Forms.Button();
            this.cmdlezina = new System.Windows.Forms.Button();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.cmdFind1 = new System.Windows.Forms.Button();
            this.cmdQuery1 = new System.Windows.Forms.Button();
            this.cmdQueryParameters = new System.Windows.Forms.Button();
            this.cmdQueryNamedParamters = new System.Windows.Forms.Button();
            this.cmdQueryNamedParameters1 = new System.Windows.Forms.Button();
            this.smdEnumerable = new System.Windows.Forms.Button();
            this.cmdScalar = new System.Windows.Forms.Button();
            this.cmdUnique = new System.Windows.Forms.Button();
            this.cmdMultiple = new System.Windows.Forms.Button();
            this.cmdPaging = new System.Windows.Forms.Button();
            this.cmdCriteria = new System.Windows.Forms.Button();
            this.cmdQueryOver = new System.Windows.Forms.Button();
            this.cmdSQL = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdTransaction = new System.Windows.Forms.Button();
            this.cmdLINQ = new System.Windows.Forms.Button();
            this.cmdLINQ1 = new System.Windows.Forms.Button();
            this.cmdLINQ2 = new System.Windows.Forms.Button();
            this.button_dtoexample1 = new System.Windows.Forms.Button();
            this.cmdCreateOdrzavaHigijenuNa = new System.Windows.Forms.Button();
            this.cmdCreateRadiNa = new System.Windows.Forms.Button();
            this.cmdCreateObavlja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdRead
            // 
            this.cmdRead.Location = new System.Drawing.Point(12, 10);
            this.cmdRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdRead.Name = "cmdRead";
            this.cmdRead.Size = new System.Drawing.Size(233, 28);
            this.cmdRead.TabIndex = 0;
            this.cmdRead.Text = "Ucitavanje podataka o odeljenju";
            this.cmdRead.UseVisualStyleBackColor = true;
            this.cmdRead.Click += new System.EventHandler(this.cmdRead_Click);
            // 
            // cmdCreate
            // 
            this.cmdCreate.Location = new System.Drawing.Point(12, 190);
            this.cmdCreate.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(233, 32);
            this.cmdCreate.TabIndex = 1;
            this.cmdCreate.Text = "Kreiranje novog odeljenja";
            this.cmdCreate.UseVisualStyleBackColor = true;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // cmdManyToOne
            // 
            this.cmdManyToOne.Location = new System.Drawing.Point(12, 230);
            this.cmdManyToOne.Margin = new System.Windows.Forms.Padding(4);
            this.cmdManyToOne.Name = "cmdManyToOne";
            this.cmdManyToOne.Size = new System.Drawing.Size(233, 42);
            this.cmdManyToOne.TabIndex = 2;
            this.cmdManyToOne.Text = "Veza Many-to-One Stomatoloska_stolica";
            this.cmdManyToOne.UseVisualStyleBackColor = true;
            this.cmdManyToOne.Click += new System.EventHandler(this.cmdManyToOne_Click);
            // 
            // cmdOneToMany
            // 
            this.cmdOneToMany.Location = new System.Drawing.Point(13, 280);
            this.cmdOneToMany.Margin = new System.Windows.Forms.Padding(4);
            this.cmdOneToMany.Name = "cmdOneToMany";
            this.cmdOneToMany.Size = new System.Drawing.Size(233, 47);
            this.cmdOneToMany.TabIndex = 3;
            this.cmdOneToMany.Text = "Veza One-to-Many Stomatoloska_stolica";
            this.cmdOneToMany.UseVisualStyleBackColor = true;
            this.cmdOneToMany.Click += new System.EventHandler(this.cmdOneToMany_Click);
            // 
            // cmdReadSmena
            // 
            this.cmdReadSmena.Location = new System.Drawing.Point(12, 44);
            this.cmdReadSmena.Margin = new System.Windows.Forms.Padding(4);
            this.cmdReadSmena.Name = "cmdReadSmena";
            this.cmdReadSmena.Size = new System.Drawing.Size(233, 28);
            this.cmdReadSmena.TabIndex = 6;
            this.cmdReadSmena.Text = "Ucitavanje podataka o smeni";
            this.cmdReadSmena.UseVisualStyleBackColor = true;
            this.cmdReadSmena.Click += new System.EventHandler(this.cmdReadSmena_Click);
            // 
            // cmdCreateSmena
            // 
            this.cmdCreateSmena.Location = new System.Drawing.Point(12, 80);
            this.cmdCreateSmena.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCreateSmena.Name = "cmdCreateSmena";
            this.cmdCreateSmena.Size = new System.Drawing.Size(233, 30);
            this.cmdCreateSmena.TabIndex = 7;
            this.cmdCreateSmena.Text = "Dodavanje nove smene";
            this.cmdCreateSmena.UseVisualStyleBackColor = true;
            this.cmdCreateSmena.Click += new System.EventHandler(this.cmdCreateSmena_Click);
            // 
            // cmdManyToOneOdeljenje
            // 
            this.cmdManyToOneOdeljenje.Location = new System.Drawing.Point(12, 118);
            this.cmdManyToOneOdeljenje.Margin = new System.Windows.Forms.Padding(4);
            this.cmdManyToOneOdeljenje.Name = "cmdManyToOneOdeljenje";
            this.cmdManyToOneOdeljenje.Size = new System.Drawing.Size(233, 26);
            this.cmdManyToOneOdeljenje.TabIndex = 8;
            this.cmdManyToOneOdeljenje.Text = "Veza Many-to-One Odeljenje";
            this.cmdManyToOneOdeljenje.UseVisualStyleBackColor = true;
            this.cmdManyToOneOdeljenje.Click += new System.EventHandler(this.cmdManyToOneOdeljenje_Click);
            // 
            // cmdOneToManyOdeljenje
            // 
            this.cmdOneToManyOdeljenje.Location = new System.Drawing.Point(12, 152);
            this.cmdOneToManyOdeljenje.Margin = new System.Windows.Forms.Padding(4);
            this.cmdOneToManyOdeljenje.Name = "cmdOneToManyOdeljenje";
            this.cmdOneToManyOdeljenje.Size = new System.Drawing.Size(233, 30);
            this.cmdOneToManyOdeljenje.TabIndex = 9;
            this.cmdOneToManyOdeljenje.Text = "Veza One-to-Many Odeljenje";
            this.cmdOneToManyOdeljenje.UseVisualStyleBackColor = true;
            this.cmdOneToManyOdeljenje.Click += new System.EventHandler(this.cmdOneToManyOdeljenje_Click);
            // 
            // cmdCreateStomatoloskaStolica
            // 
            this.cmdCreateStomatoloskaStolica.Location = new System.Drawing.Point(12, 335);
            this.cmdCreateStomatoloskaStolica.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCreateStomatoloskaStolica.Name = "cmdCreateStomatoloskaStolica";
            this.cmdCreateStomatoloskaStolica.Size = new System.Drawing.Size(233, 28);
            this.cmdCreateStomatoloskaStolica.TabIndex = 10;
            this.cmdCreateStomatoloskaStolica.Text = "Kreiranje nove Stomatoloske stolice";
            this.cmdCreateStomatoloskaStolica.UseVisualStyleBackColor = true;
            this.cmdCreateStomatoloskaStolica.Click += new System.EventHandler(this.cmdCreateStomatoloskaStolica_Click);
            // 
            // cmdTPCMedicinsko
            // 
            this.cmdTPCMedicinsko.Location = new System.Drawing.Point(253, 80);
            this.cmdTPCMedicinsko.Margin = new System.Windows.Forms.Padding(4);
            this.cmdTPCMedicinsko.Name = "cmdTPCMedicinsko";
            this.cmdTPCMedicinsko.Size = new System.Drawing.Size(201, 42);
            this.cmdTPCMedicinsko.TabIndex = 13;
            this.cmdTPCMedicinsko.Text = "Table-per-Classes inheritance Medicinsko Osoblje";
            this.cmdTPCMedicinsko.UseVisualStyleBackColor = true;
            this.cmdTPCMedicinsko.Click += new System.EventHandler(this.cmdTPCMedicinsko_Click);
            // 
            // cmdTPCNemedicinsko
            // 
            this.cmdTPCNemedicinsko.Location = new System.Drawing.Point(253, 130);
            this.cmdTPCNemedicinsko.Margin = new System.Windows.Forms.Padding(4);
            this.cmdTPCNemedicinsko.Name = "cmdTPCNemedicinsko";
            this.cmdTPCNemedicinsko.Size = new System.Drawing.Size(201, 47);
            this.cmdTPCNemedicinsko.TabIndex = 14;
            this.cmdTPCNemedicinsko.Text = "Table-per-Classes inheritance Nemedicinsko";
            this.cmdTPCNemedicinsko.UseVisualStyleBackColor = true;
            this.cmdTPCNemedicinsko.Click += new System.EventHandler(this.cmdTPCNemedicinsko_Click);
            // 
            // cmdCreateMedicinsko
            // 
            this.cmdCreateMedicinsko.Location = new System.Drawing.Point(253, 185);
            this.cmdCreateMedicinsko.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCreateMedicinsko.Name = "cmdCreateMedicinsko";
            this.cmdCreateMedicinsko.Size = new System.Drawing.Size(201, 27);
            this.cmdCreateMedicinsko.TabIndex = 15;
            this.cmdCreateMedicinsko.Text = "Kreiranje medicinskog osoblja";
            this.cmdCreateMedicinsko.UseVisualStyleBackColor = true;
            this.cmdCreateMedicinsko.Click += new System.EventHandler(this.cmdCreateMedicinsko_Click);
            // 
            // cmdCreateNemedicinsko
            // 
            this.cmdCreateNemedicinsko.Location = new System.Drawing.Point(253, 220);
            this.cmdCreateNemedicinsko.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCreateNemedicinsko.Name = "cmdCreateNemedicinsko";
            this.cmdCreateNemedicinsko.Size = new System.Drawing.Size(201, 44);
            this.cmdCreateNemedicinsko.TabIndex = 16;
            this.cmdCreateNemedicinsko.Text = "Kreiranje nemedicinskog osoblja";
            this.cmdCreateNemedicinsko.UseVisualStyleBackColor = true;
            this.cmdCreateNemedicinsko.Click += new System.EventHandler(this.cmdCreateNemedicinsko_Click);
            // 
            // cmdTPCHPacijent
            // 
            this.cmdTPCHPacijent.Location = new System.Drawing.Point(253, 272);
            this.cmdTPCHPacijent.Margin = new System.Windows.Forms.Padding(4);
            this.cmdTPCHPacijent.Name = "cmdTPCHPacijent";
            this.cmdTPCHPacijent.Size = new System.Drawing.Size(201, 48);
            this.cmdTPCHPacijent.TabIndex = 17;
            this.cmdTPCHPacijent.Text = "Table-per-Class-Hierarchy inheritance Pacijent";
            this.cmdTPCHPacijent.UseVisualStyleBackColor = true;
            this.cmdTPCHPacijent.Click += new System.EventHandler(this.cmdTPCHPacijent_Click);
            // 
            // cmdCreateSubclassPacijent
            // 
            this.cmdCreateSubclassPacijent.Location = new System.Drawing.Point(253, 328);
            this.cmdCreateSubclassPacijent.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCreateSubclassPacijent.Name = "cmdCreateSubclassPacijent";
            this.cmdCreateSubclassPacijent.Size = new System.Drawing.Size(201, 29);
            this.cmdCreateSubclassPacijent.TabIndex = 18;
            this.cmdCreateSubclassPacijent.Text = "Kreiranje podklase Pacijent";
            this.cmdCreateSubclassPacijent.UseVisualStyleBackColor = true;
            this.cmdCreateSubclassPacijent.Click += new System.EventHandler(this.cmdCreateSubclassPacijent_Click);
            // 
            // cmdGetPacijent
            // 
            this.cmdGetPacijent.Location = new System.Drawing.Point(253, 365);
            this.cmdGetPacijent.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGetPacijent.Name = "cmdGetPacijent";
            this.cmdGetPacijent.Size = new System.Drawing.Size(201, 51);
            this.cmdGetPacijent.TabIndex = 19;
            this.cmdGetPacijent.Text = "Koriscenje metode Get Pacijent";
            this.cmdGetPacijent.UseVisualStyleBackColor = true;
            this.cmdGetPacijent.Click += new System.EventHandler(this.cmdGetPacijent_Click);
            // 
            // cmdManyToOnePacijent
            // 
            this.cmdManyToOnePacijent.Location = new System.Drawing.Point(12, 370);
            this.cmdManyToOnePacijent.Name = "cmdManyToOnePacijent";
            this.cmdManyToOnePacijent.Size = new System.Drawing.Size(233, 28);
            this.cmdManyToOnePacijent.TabIndex = 20;
            this.cmdManyToOnePacijent.Text = "Veza Many-to-One Pacijent";
            this.cmdManyToOnePacijent.UseVisualStyleBackColor = true;
            this.cmdManyToOnePacijent.Click += new System.EventHandler(this.cmdManyToOnePacijent_Click);
            // 
            // cmdOneToManyPacijent
            // 
            this.cmdOneToManyPacijent.Location = new System.Drawing.Point(12, 404);
            this.cmdOneToManyPacijent.Name = "cmdOneToManyPacijent";
            this.cmdOneToManyPacijent.Size = new System.Drawing.Size(233, 27);
            this.cmdOneToManyPacijent.TabIndex = 21;
            this.cmdOneToManyPacijent.Text = "Veza One-to-Many Pacijent";
            this.cmdOneToManyPacijent.UseVisualStyleBackColor = true;
            this.cmdOneToManyPacijent.Click += new System.EventHandler(this.cmdOneToManyPacijent_Click);
            // 
            // cmdManyToOneStacionarni
            // 
            this.cmdManyToOneStacionarni.Location = new System.Drawing.Point(12, 437);
            this.cmdManyToOneStacionarni.Name = "cmdManyToOneStacionarni";
            this.cmdManyToOneStacionarni.Size = new System.Drawing.Size(233, 33);
            this.cmdManyToOneStacionarni.TabIndex = 22;
            this.cmdManyToOneStacionarni.Text = "Veza Many-to-One Stacionarni";
            this.cmdManyToOneStacionarni.UseVisualStyleBackColor = true;
            this.cmdManyToOneStacionarni.Click += new System.EventHandler(this.cmdManyToOneStacionarni_Click);
            // 
            // cmdOneToManyStacionarni
            // 
            this.cmdOneToManyStacionarni.Location = new System.Drawing.Point(253, 10);
            this.cmdOneToManyStacionarni.Name = "cmdOneToManyStacionarni";
            this.cmdOneToManyStacionarni.Size = new System.Drawing.Size(201, 28);
            this.cmdOneToManyStacionarni.TabIndex = 23;
            this.cmdOneToManyStacionarni.Text = "Veza One-to-Many Stacionarni";
            this.cmdOneToManyStacionarni.UseVisualStyleBackColor = true;
            this.cmdOneToManyStacionarni.Click += new System.EventHandler(this.cmdOneToManyStacionarni_Click);
            // 
            // cmdCreatePacijenta
            // 
            this.cmdCreatePacijenta.Location = new System.Drawing.Point(253, 44);
            this.cmdCreatePacijenta.Name = "cmdCreatePacijenta";
            this.cmdCreatePacijenta.Size = new System.Drawing.Size(201, 29);
            this.cmdCreatePacijenta.TabIndex = 24;
            this.cmdCreatePacijenta.Text = "Kreiranje novog Pacijenta";
            this.cmdCreatePacijenta.UseVisualStyleBackColor = true;
            this.cmdCreatePacijenta.Click += new System.EventHandler(this.cmdCreatePacijenta_Click);
            // 
            // cmdlezina
            // 
            this.cmdlezina.Location = new System.Drawing.Point(252, 423);
            this.cmdlezina.Name = "cmdlezina";
            this.cmdlezina.Size = new System.Drawing.Size(201, 47);
            this.cmdlezina.TabIndex = 30;
            this.cmdlezina.Text = "Kreiranje veze LEZI_NA";
            this.cmdlezina.UseVisualStyleBackColor = true;
            this.cmdlezina.Click += new System.EventHandler(this.cmdlezina_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Location = new System.Drawing.Point(459, 124);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(202, 28);
            this.cmdRefresh.TabIndex = 33;
            this.cmdRefresh.Text = "Koriscenje metode Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdFind1
            // 
            this.cmdFind1.Location = new System.Drawing.Point(459, 158);
            this.cmdFind1.Name = "cmdFind1";
            this.cmdFind1.Size = new System.Drawing.Size(202, 27);
            this.cmdFind1.TabIndex = 34;
            this.cmdFind1.Text = "Kreiranje upita";
            this.cmdFind1.UseVisualStyleBackColor = true;
            this.cmdFind1.Click += new System.EventHandler(this.cmdFind1_Click);
            // 
            // cmdQuery1
            // 
            this.cmdQuery1.Location = new System.Drawing.Point(459, 191);
            this.cmdQuery1.Name = "cmdQuery1";
            this.cmdQuery1.Size = new System.Drawing.Size(204, 32);
            this.cmdQuery1.TabIndex = 35;
            this.cmdQuery1.Text = "Kreiranje upita 1";
            this.cmdQuery1.UseVisualStyleBackColor = true;
            this.cmdQuery1.Click += new System.EventHandler(this.cmdQuery1_Click);
            // 
            // cmdQueryParameters
            // 
            this.cmdQueryParameters.Location = new System.Drawing.Point(461, 229);
            this.cmdQueryParameters.Name = "cmdQueryParameters";
            this.cmdQueryParameters.Size = new System.Drawing.Size(202, 29);
            this.cmdQueryParameters.TabIndex = 36;
            this.cmdQueryParameters.Text = "Kreiranje upita sa parametrima";
            this.cmdQueryParameters.UseVisualStyleBackColor = true;
            this.cmdQueryParameters.Click += new System.EventHandler(this.cmdQueryParameters_Click);
            // 
            // cmdQueryNamedParamters
            // 
            this.cmdQueryNamedParamters.Location = new System.Drawing.Point(460, 264);
            this.cmdQueryNamedParamters.Name = "cmdQueryNamedParamters";
            this.cmdQueryNamedParamters.Size = new System.Drawing.Size(202, 44);
            this.cmdQueryNamedParamters.TabIndex = 37;
            this.cmdQueryNamedParamters.Text = "Kreiranje upita sa imenovanim parametrima";
            this.cmdQueryNamedParamters.UseVisualStyleBackColor = true;
            this.cmdQueryNamedParamters.Click += new System.EventHandler(this.cmdQueryNamedParamters_Click);
            // 
            // cmdQueryNamedParameters1
            // 
            this.cmdQueryNamedParameters1.Location = new System.Drawing.Point(461, 314);
            this.cmdQueryNamedParameters1.Name = "cmdQueryNamedParameters1";
            this.cmdQueryNamedParameters1.Size = new System.Drawing.Size(202, 52);
            this.cmdQueryNamedParameters1.TabIndex = 38;
            this.cmdQueryNamedParameters1.Text = "Kreiranje upita sa imenovanim parametrima 1";
            this.cmdQueryNamedParameters1.UseVisualStyleBackColor = true;
            this.cmdQueryNamedParameters1.Click += new System.EventHandler(this.cmdQueryNamedParameters1_Click);
            // 
            // smdEnumerable
            // 
            this.smdEnumerable.Location = new System.Drawing.Point(461, 372);
            this.smdEnumerable.Name = "smdEnumerable";
            this.smdEnumerable.Size = new System.Drawing.Size(202, 28);
            this.smdEnumerable.TabIndex = 39;
            this.smdEnumerable.Text = "Koriscenje Enumerable";
            this.smdEnumerable.UseVisualStyleBackColor = true;
            this.smdEnumerable.Click += new System.EventHandler(this.smdEnumerable_Click);
            // 
            // cmdScalar
            // 
            this.cmdScalar.Location = new System.Drawing.Point(459, 406);
            this.cmdScalar.Name = "cmdScalar";
            this.cmdScalar.Size = new System.Drawing.Size(204, 25);
            this.cmdScalar.TabIndex = 40;
            this.cmdScalar.Text = "Skalarni rezultati";
            this.cmdScalar.UseVisualStyleBackColor = true;
            this.cmdScalar.Click += new System.EventHandler(this.cmdScalar_Click);
            // 
            // cmdUnique
            // 
            this.cmdUnique.Location = new System.Drawing.Point(461, 437);
            this.cmdUnique.Name = "cmdUnique";
            this.cmdUnique.Size = new System.Drawing.Size(201, 33);
            this.cmdUnique.TabIndex = 41;
            this.cmdUnique.Text = "Unique rezultat";
            this.cmdUnique.UseVisualStyleBackColor = true;
            this.cmdUnique.Click += new System.EventHandler(this.cmdUnique_Click);
            // 
            // cmdMultiple
            // 
            this.cmdMultiple.Location = new System.Drawing.Point(668, 10);
            this.cmdMultiple.Name = "cmdMultiple";
            this.cmdMultiple.Size = new System.Drawing.Size(194, 31);
            this.cmdMultiple.TabIndex = 42;
            this.cmdMultiple.Text = "Visestruki rezultati";
            this.cmdMultiple.UseVisualStyleBackColor = true;
            this.cmdMultiple.Click += new System.EventHandler(this.cmdMultiple_Click);
            // 
            // cmdPaging
            // 
            this.cmdPaging.Location = new System.Drawing.Point(668, 48);
            this.cmdPaging.Name = "cmdPaging";
            this.cmdPaging.Size = new System.Drawing.Size(194, 25);
            this.cmdPaging.TabIndex = 43;
            this.cmdPaging.Text = "Stranicenje";
            this.cmdPaging.UseVisualStyleBackColor = true;
            this.cmdPaging.Click += new System.EventHandler(this.cmdPaging_Click);
            // 
            // cmdCriteria
            // 
            this.cmdCriteria.Location = new System.Drawing.Point(668, 79);
            this.cmdCriteria.Name = "cmdCriteria";
            this.cmdCriteria.Size = new System.Drawing.Size(194, 31);
            this.cmdCriteria.TabIndex = 44;
            this.cmdCriteria.Text = "Kreiranje Criteria";
            this.cmdCriteria.UseVisualStyleBackColor = true;
            this.cmdCriteria.Click += new System.EventHandler(this.cmdCriteria_Click);
            // 
            // cmdQueryOver
            // 
            this.cmdQueryOver.Location = new System.Drawing.Point(667, 116);
            this.cmdQueryOver.Name = "cmdQueryOver";
            this.cmdQueryOver.Size = new System.Drawing.Size(194, 23);
            this.cmdQueryOver.TabIndex = 45;
            this.cmdQueryOver.Text = "Kreiranje QueryOver";
            this.cmdQueryOver.UseVisualStyleBackColor = true;
            this.cmdQueryOver.Click += new System.EventHandler(this.cmdQueryOver_Click);
            // 
            // cmdSQL
            // 
            this.cmdSQL.Location = new System.Drawing.Point(668, 145);
            this.cmdSQL.Name = "cmdSQL";
            this.cmdSQL.Size = new System.Drawing.Size(194, 23);
            this.cmdSQL.TabIndex = 46;
            this.cmdSQL.Text = "Native SQL";
            this.cmdSQL.UseVisualStyleBackColor = true;
            this.cmdSQL.Click += new System.EventHandler(this.cmdSQL_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(667, 174);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(194, 23);
            this.cmdUpdate.TabIndex = 47;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(667, 203);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(194, 34);
            this.cmdDelete.TabIndex = 48;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdTransaction
            // 
            this.cmdTransaction.Location = new System.Drawing.Point(667, 242);
            this.cmdTransaction.Name = "cmdTransaction";
            this.cmdTransaction.Size = new System.Drawing.Size(194, 30);
            this.cmdTransaction.TabIndex = 49;
            this.cmdTransaction.Text = "Transakcija";
            this.cmdTransaction.UseVisualStyleBackColor = true;
            this.cmdTransaction.Click += new System.EventHandler(this.cmdTransaction_Click);
            // 
            // cmdLINQ
            // 
            this.cmdLINQ.Location = new System.Drawing.Point(667, 278);
            this.cmdLINQ.Name = "cmdLINQ";
            this.cmdLINQ.Size = new System.Drawing.Size(194, 30);
            this.cmdLINQ.TabIndex = 50;
            this.cmdLINQ.Text = "LINQ";
            this.cmdLINQ.UseVisualStyleBackColor = true;
            this.cmdLINQ.Click += new System.EventHandler(this.cmdLINQ_Click);
            // 
            // cmdLINQ1
            // 
            this.cmdLINQ1.Location = new System.Drawing.Point(668, 314);
            this.cmdLINQ1.Name = "cmdLINQ1";
            this.cmdLINQ1.Size = new System.Drawing.Size(194, 29);
            this.cmdLINQ1.TabIndex = 51;
            this.cmdLINQ1.Text = "LINQ 1";
            this.cmdLINQ1.UseVisualStyleBackColor = true;
            this.cmdLINQ1.Click += new System.EventHandler(this.cmdLINQ1_Click);
            // 
            // cmdLINQ2
            // 
            this.cmdLINQ2.Location = new System.Drawing.Point(667, 349);
            this.cmdLINQ2.Name = "cmdLINQ2";
            this.cmdLINQ2.Size = new System.Drawing.Size(195, 35);
            this.cmdLINQ2.TabIndex = 52;
            this.cmdLINQ2.Text = "LINQ 2";
            this.cmdLINQ2.UseVisualStyleBackColor = true;
            this.cmdLINQ2.Click += new System.EventHandler(this.cmdLINQ2_Click);
            // 
            // button_dtoexample1
            // 
            this.button_dtoexample1.Location = new System.Drawing.Point(667, 390);
            this.button_dtoexample1.Name = "button_dtoexample1";
            this.button_dtoexample1.Size = new System.Drawing.Size(195, 32);
            this.button_dtoexample1.TabIndex = 53;
            this.button_dtoexample1.Text = "Pregled pacijenata";
            this.button_dtoexample1.UseVisualStyleBackColor = true;
            this.button_dtoexample1.Click += new System.EventHandler(this.button_dtoexample1_Click);
            // 
            // cmdCreateOdrzavaHigijenuNa
            // 
            this.cmdCreateOdrzavaHigijenuNa.Location = new System.Drawing.Point(460, 10);
            this.cmdCreateOdrzavaHigijenuNa.Name = "cmdCreateOdrzavaHigijenuNa";
            this.cmdCreateOdrzavaHigijenuNa.Size = new System.Drawing.Size(202, 41);
            this.cmdCreateOdrzavaHigijenuNa.TabIndex = 54;
            this.cmdCreateOdrzavaHigijenuNa.Text = "Kreiranje veze ODRZAVA_HIGIJENU_NA";
            this.cmdCreateOdrzavaHigijenuNa.UseVisualStyleBackColor = true;
            this.cmdCreateOdrzavaHigijenuNa.Click += new System.EventHandler(this.cmdCreateOdrzavaHigijenuNa_Click);
            // 
            // cmdCreateRadiNa
            // 
            this.cmdCreateRadiNa.Location = new System.Drawing.Point(460, 57);
            this.cmdCreateRadiNa.Name = "cmdCreateRadiNa";
            this.cmdCreateRadiNa.Size = new System.Drawing.Size(202, 23);
            this.cmdCreateRadiNa.TabIndex = 55;
            this.cmdCreateRadiNa.Text = "Kreiranje veze RADI_NA";
            this.cmdCreateRadiNa.UseVisualStyleBackColor = true;
            this.cmdCreateRadiNa.Click += new System.EventHandler(this.cmdCreateRadiNa_Click);
            // 
            // cmdCreateObavlja
            // 
            this.cmdCreateObavlja.Location = new System.Drawing.Point(459, 86);
            this.cmdCreateObavlja.Name = "cmdCreateObavlja";
            this.cmdCreateObavlja.Size = new System.Drawing.Size(202, 32);
            this.cmdCreateObavlja.TabIndex = 56;
            this.cmdCreateObavlja.Text = "Kreiranje veze OBAVLJA";
            this.cmdCreateObavlja.UseVisualStyleBackColor = true;
            this.cmdCreateObavlja.Click += new System.EventHandler(this.cmdCreateObavlja_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 481);
            this.Controls.Add(this.cmdCreateObavlja);
            this.Controls.Add(this.cmdCreateRadiNa);
            this.Controls.Add(this.cmdCreateOdrzavaHigijenuNa);
            this.Controls.Add(this.button_dtoexample1);
            this.Controls.Add(this.cmdLINQ2);
            this.Controls.Add(this.cmdLINQ1);
            this.Controls.Add(this.cmdLINQ);
            this.Controls.Add(this.cmdTransaction);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdSQL);
            this.Controls.Add(this.cmdQueryOver);
            this.Controls.Add(this.cmdCriteria);
            this.Controls.Add(this.cmdPaging);
            this.Controls.Add(this.cmdMultiple);
            this.Controls.Add(this.cmdUnique);
            this.Controls.Add(this.cmdScalar);
            this.Controls.Add(this.smdEnumerable);
            this.Controls.Add(this.cmdQueryNamedParameters1);
            this.Controls.Add(this.cmdQueryNamedParamters);
            this.Controls.Add(this.cmdQueryParameters);
            this.Controls.Add(this.cmdQuery1);
            this.Controls.Add(this.cmdFind1);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.cmdlezina);
            this.Controls.Add(this.cmdCreatePacijenta);
            this.Controls.Add(this.cmdOneToManyStacionarni);
            this.Controls.Add(this.cmdManyToOneStacionarni);
            this.Controls.Add(this.cmdOneToManyPacijent);
            this.Controls.Add(this.cmdManyToOnePacijent);
            this.Controls.Add(this.cmdGetPacijent);
            this.Controls.Add(this.cmdCreateSubclassPacijent);
            this.Controls.Add(this.cmdTPCHPacijent);
            this.Controls.Add(this.cmdCreateNemedicinsko);
            this.Controls.Add(this.cmdCreateMedicinsko);
            this.Controls.Add(this.cmdTPCNemedicinsko);
            this.Controls.Add(this.cmdTPCMedicinsko);
            this.Controls.Add(this.cmdCreateStomatoloskaStolica);
            this.Controls.Add(this.cmdOneToManyOdeljenje);
            this.Controls.Add(this.cmdManyToOneOdeljenje);
            this.Controls.Add(this.cmdCreateSmena);
            this.Controls.Add(this.cmdReadSmena);
            this.Controls.Add(this.cmdOneToMany);
            this.Controls.Add(this.cmdManyToOne);
            this.Controls.Add(this.cmdCreate);
            this.Controls.Add(this.cmdRead);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRead;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.Button cmdManyToOne;
        private System.Windows.Forms.Button cmdOneToMany;
        private System.Windows.Forms.Button cmdReadSmena;
        private System.Windows.Forms.Button cmdCreateSmena;
        private System.Windows.Forms.Button cmdManyToOneOdeljenje;
        private System.Windows.Forms.Button cmdOneToManyOdeljenje;
        private System.Windows.Forms.Button cmdCreateStomatoloskaStolica;
        private System.Windows.Forms.Button cmdTPCMedicinsko;
        private System.Windows.Forms.Button cmdTPCNemedicinsko;
        private System.Windows.Forms.Button cmdCreateMedicinsko;
        private System.Windows.Forms.Button cmdCreateNemedicinsko;
        private System.Windows.Forms.Button cmdTPCHPacijent;
        private System.Windows.Forms.Button cmdCreateSubclassPacijent;
        private System.Windows.Forms.Button cmdGetPacijent;
        private System.Windows.Forms.Button cmdManyToOnePacijent;
        private System.Windows.Forms.Button cmdOneToManyPacijent;
        private System.Windows.Forms.Button cmdManyToOneStacionarni;
        private System.Windows.Forms.Button cmdOneToManyStacionarni;
        private System.Windows.Forms.Button cmdCreatePacijenta;
        private System.Windows.Forms.Button cmdlezina;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Button cmdFind1;
        private System.Windows.Forms.Button cmdQuery1;
        private System.Windows.Forms.Button cmdQueryParameters;
        private System.Windows.Forms.Button cmdQueryNamedParamters;
        private System.Windows.Forms.Button cmdQueryNamedParameters1;
        private System.Windows.Forms.Button smdEnumerable;
        private System.Windows.Forms.Button cmdScalar;
        private System.Windows.Forms.Button cmdUnique;
        private System.Windows.Forms.Button cmdMultiple;
        private System.Windows.Forms.Button cmdPaging;
        private System.Windows.Forms.Button cmdCriteria;
        private System.Windows.Forms.Button cmdQueryOver;
        private System.Windows.Forms.Button cmdSQL;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdTransaction;
        private System.Windows.Forms.Button cmdLINQ;
        private System.Windows.Forms.Button cmdLINQ1;
        private System.Windows.Forms.Button cmdLINQ2;
        private System.Windows.Forms.Button button_dtoexample1;
        private System.Windows.Forms.Button cmdCreateOdrzavaHigijenuNa;
        private System.Windows.Forms.Button cmdCreateRadiNa;
        private System.Windows.Forms.Button cmdCreateObavlja;
    }
}

