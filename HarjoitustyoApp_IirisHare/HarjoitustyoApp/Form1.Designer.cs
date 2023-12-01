namespace HarjoitustyoApp
{
    partial class FrmHarjoitustyo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.dgvTiedot = new System.Windows.Forms.DataGridView();
            this.tbYksikko = new System.Windows.Forms.TextBox();
            this.lblYksikko = new System.Windows.Forms.Label();
            this.tbTyonimike = new System.Windows.Forms.TextBox();
            this.lblTyonimike = new System.Windows.Forms.Label();
            this.lblPaattymispaiva = new System.Windows.Forms.Label();
            this.dtpPaattymispaiva = new System.Windows.Forms.DateTimePicker();
            this.dtpAlkamispaiva = new System.Windows.Forms.DateTimePicker();
            this.lblAlkamispaiva = new System.Windows.Forms.Label();
            this.lblToimisuhteenTiedot = new System.Windows.Forms.Label();
            this.lblHenkilotiedot = new System.Windows.Forms.Label();
            this.tbPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.tbPostinumero = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.lblKatuosoite = new System.Windows.Forms.Label();
            this.lblPostinumero = new System.Windows.Forms.Label();
            this.lblPostitoimipaikka = new System.Windows.Forms.Label();
            this.tbHetu = new System.Windows.Forms.TextBox();
            this.lblHetu = new System.Windows.Forms.Label();
            this.lblKotiosoite = new System.Windows.Forms.Label();
            this.tbKutsumanimi = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.lblKutsumanimi = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.tbEtunimet = new System.Windows.Forms.TextBox();
            this.lblEtunimet = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toiminnotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTallenna = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLopeta = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiedot)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPoista);
            this.panel1.Controls.Add(this.btnLisaa);
            this.panel1.Controls.Add(this.dgvTiedot);
            this.panel1.Controls.Add(this.tbYksikko);
            this.panel1.Controls.Add(this.lblYksikko);
            this.panel1.Controls.Add(this.tbTyonimike);
            this.panel1.Controls.Add(this.lblTyonimike);
            this.panel1.Controls.Add(this.lblPaattymispaiva);
            this.panel1.Controls.Add(this.dtpPaattymispaiva);
            this.panel1.Controls.Add(this.dtpAlkamispaiva);
            this.panel1.Controls.Add(this.lblAlkamispaiva);
            this.panel1.Controls.Add(this.lblToimisuhteenTiedot);
            this.panel1.Controls.Add(this.lblHenkilotiedot);
            this.panel1.Controls.Add(this.tbPostitoimipaikka);
            this.panel1.Controls.Add(this.tbPostinumero);
            this.panel1.Controls.Add(this.tbKatuosoite);
            this.panel1.Controls.Add(this.lblKatuosoite);
            this.panel1.Controls.Add(this.lblPostinumero);
            this.panel1.Controls.Add(this.lblPostitoimipaikka);
            this.panel1.Controls.Add(this.tbHetu);
            this.panel1.Controls.Add(this.lblHetu);
            this.panel1.Controls.Add(this.lblKotiosoite);
            this.panel1.Controls.Add(this.tbKutsumanimi);
            this.panel1.Controls.Add(this.tbSukunimi);
            this.panel1.Controls.Add(this.lblKutsumanimi);
            this.panel1.Controls.Add(this.lblSukunimi);
            this.panel1.Controls.Add(this.tbEtunimet);
            this.panel1.Controls.Add(this.lblEtunimet);
            this.panel1.Location = new System.Drawing.Point(14, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 775);
            this.panel1.TabIndex = 28;
            // 
            // btnPoista
            // 
            this.btnPoista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoista.Location = new System.Drawing.Point(394, 366);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(106, 39);
            this.btnPoista.TabIndex = 28;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaa.Location = new System.Drawing.Point(538, 324);
            this.btnLisaa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(225, 98);
            this.btnLisaa.TabIndex = 27;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // dgvTiedot
            // 
            this.dgvTiedot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiedot.Location = new System.Drawing.Point(34, 449);
            this.dgvTiedot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTiedot.Name = "dgvTiedot";
            this.dgvTiedot.RowHeadersWidth = 51;
            this.dgvTiedot.RowTemplate.Height = 24;
            this.dgvTiedot.Size = new System.Drawing.Size(809, 281);
            this.dgvTiedot.TabIndex = 26;
            this.dgvTiedot.DoubleClick += new System.EventHandler(this.dgvTiedot_DoubleClick);
            // 
            // tbYksikko
            // 
            this.tbYksikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYksikko.Location = new System.Drawing.Point(538, 219);
            this.tbYksikko.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbYksikko.Name = "tbYksikko";
            this.tbYksikko.Size = new System.Drawing.Size(156, 32);
            this.tbYksikko.TabIndex = 24;
            // 
            // lblYksikko
            // 
            this.lblYksikko.AutoSize = true;
            this.lblYksikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYksikko.Location = new System.Drawing.Point(375, 222);
            this.lblYksikko.Name = "lblYksikko";
            this.lblYksikko.Size = new System.Drawing.Size(89, 26);
            this.lblYksikko.TabIndex = 23;
            this.lblYksikko.Text = "Yksikkö";
            // 
            // tbTyonimike
            // 
            this.tbTyonimike.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTyonimike.Location = new System.Drawing.Point(538, 169);
            this.tbTyonimike.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTyonimike.Name = "tbTyonimike";
            this.tbTyonimike.Size = new System.Drawing.Size(156, 32);
            this.tbTyonimike.TabIndex = 22;
            // 
            // lblTyonimike
            // 
            this.lblTyonimike.AutoSize = true;
            this.lblTyonimike.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTyonimike.Location = new System.Drawing.Point(375, 175);
            this.lblTyonimike.Name = "lblTyonimike";
            this.lblTyonimike.Size = new System.Drawing.Size(111, 26);
            this.lblTyonimike.TabIndex = 21;
            this.lblTyonimike.Text = "Työnimike";
            // 
            // lblPaattymispaiva
            // 
            this.lblPaattymispaiva.AutoSize = true;
            this.lblPaattymispaiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaattymispaiva.Location = new System.Drawing.Point(370, 126);
            this.lblPaattymispaiva.Name = "lblPaattymispaiva";
            this.lblPaattymispaiva.Size = new System.Drawing.Size(161, 26);
            this.lblPaattymispaiva.TabIndex = 20;
            this.lblPaattymispaiva.Text = "Päättymispäivä";
            // 
            // dtpPaattymispaiva
            // 
            this.dtpPaattymispaiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaattymispaiva.Location = new System.Drawing.Point(538, 120);
            this.dtpPaattymispaiva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpPaattymispaiva.Name = "dtpPaattymispaiva";
            this.dtpPaattymispaiva.Size = new System.Drawing.Size(295, 32);
            this.dtpPaattymispaiva.TabIndex = 19;
            this.dtpPaattymispaiva.ValueChanged += new System.EventHandler(this.dtpPaattymispaiva_ValueChanged);
            // 
            // dtpAlkamispaiva
            // 
            this.dtpAlkamispaiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAlkamispaiva.Location = new System.Drawing.Point(538, 75);
            this.dtpAlkamispaiva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpAlkamispaiva.Name = "dtpAlkamispaiva";
            this.dtpAlkamispaiva.Size = new System.Drawing.Size(295, 32);
            this.dtpAlkamispaiva.TabIndex = 18;
            // 
            // lblAlkamispaiva
            // 
            this.lblAlkamispaiva.AutoSize = true;
            this.lblAlkamispaiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlkamispaiva.Location = new System.Drawing.Point(370, 72);
            this.lblAlkamispaiva.Name = "lblAlkamispaiva";
            this.lblAlkamispaiva.Size = new System.Drawing.Size(142, 26);
            this.lblAlkamispaiva.TabIndex = 17;
            this.lblAlkamispaiva.Text = "Alkamispäivä";
            // 
            // lblToimisuhteenTiedot
            // 
            this.lblToimisuhteenTiedot.AutoSize = true;
            this.lblToimisuhteenTiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToimisuhteenTiedot.Location = new System.Drawing.Point(370, 15);
            this.lblToimisuhteenTiedot.Name = "lblToimisuhteenTiedot";
            this.lblToimisuhteenTiedot.Size = new System.Drawing.Size(252, 29);
            this.lblToimisuhteenTiedot.TabIndex = 16;
            this.lblToimisuhteenTiedot.Text = "Toimisuhteen tiedot:";
            // 
            // lblHenkilotiedot
            // 
            this.lblHenkilotiedot.AutoSize = true;
            this.lblHenkilotiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHenkilotiedot.Location = new System.Drawing.Point(30, 15);
            this.lblHenkilotiedot.Name = "lblHenkilotiedot";
            this.lblHenkilotiedot.Size = new System.Drawing.Size(175, 29);
            this.lblHenkilotiedot.TabIndex = 15;
            this.lblHenkilotiedot.Text = "Henkilötiedot:";
            // 
            // tbPostitoimipaikka
            // 
            this.tbPostitoimipaikka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostitoimipaikka.Location = new System.Drawing.Point(196, 386);
            this.tbPostitoimipaikka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPostitoimipaikka.Name = "tbPostitoimipaikka";
            this.tbPostitoimipaikka.Size = new System.Drawing.Size(167, 32);
            this.tbPostitoimipaikka.TabIndex = 14;
            this.tbPostitoimipaikka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtunimet_KeyPress);
            this.tbPostitoimipaikka.Leave += new System.EventHandler(this.tbEtunimi_Leave);
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostinumero.Location = new System.Drawing.Point(196, 338);
            this.tbPostinumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(167, 32);
            this.tbPostinumero.TabIndex = 13;
            this.tbPostinumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostinumero_KeyPress);
            this.tbPostinumero.Leave += new System.EventHandler(this.tbPostinumero_Leave);
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKatuosoite.Location = new System.Drawing.Point(196, 295);
            this.tbKatuosoite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(167, 32);
            this.tbKatuosoite.TabIndex = 12;
            this.tbKatuosoite.Leave += new System.EventHandler(this.tbEtunimi_Leave);
            // 
            // lblKatuosoite
            // 
            this.lblKatuosoite.AutoSize = true;
            this.lblKatuosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKatuosoite.Location = new System.Drawing.Point(27, 302);
            this.lblKatuosoite.Name = "lblKatuosoite";
            this.lblKatuosoite.Size = new System.Drawing.Size(115, 26);
            this.lblKatuosoite.TabIndex = 11;
            this.lblKatuosoite.Text = "Katuosoite";
            // 
            // lblPostinumero
            // 
            this.lblPostinumero.AutoSize = true;
            this.lblPostinumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostinumero.Location = new System.Drawing.Point(29, 349);
            this.lblPostinumero.Name = "lblPostinumero";
            this.lblPostinumero.Size = new System.Drawing.Size(135, 26);
            this.lblPostinumero.TabIndex = 10;
            this.lblPostinumero.Text = "Postinumero";
            // 
            // lblPostitoimipaikka
            // 
            this.lblPostitoimipaikka.AutoSize = true;
            this.lblPostitoimipaikka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostitoimipaikka.Location = new System.Drawing.Point(27, 390);
            this.lblPostitoimipaikka.Name = "lblPostitoimipaikka";
            this.lblPostitoimipaikka.Size = new System.Drawing.Size(171, 26);
            this.lblPostitoimipaikka.TabIndex = 9;
            this.lblPostitoimipaikka.Text = "Postitoimipaikka";
            // 
            // tbHetu
            // 
            this.tbHetu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHetu.Location = new System.Drawing.Point(196, 206);
            this.tbHetu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbHetu.Name = "tbHetu";
            this.tbHetu.Size = new System.Drawing.Size(167, 32);
            this.tbHetu.TabIndex = 8;
            this.tbHetu.Leave += new System.EventHandler(this.tbHetu_Leave);
            // 
            // lblHetu
            // 
            this.lblHetu.AutoSize = true;
            this.lblHetu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHetu.Location = new System.Drawing.Point(27, 219);
            this.lblHetu.Name = "lblHetu";
            this.lblHetu.Size = new System.Drawing.Size(150, 26);
            this.lblHetu.TabIndex = 7;
            this.lblHetu.Text = "Henkilötunnus";
            // 
            // lblKotiosoite
            // 
            this.lblKotiosoite.AutoSize = true;
            this.lblKotiosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKotiosoite.Location = new System.Drawing.Point(29, 259);
            this.lblKotiosoite.Name = "lblKotiosoite";
            this.lblKotiosoite.Size = new System.Drawing.Size(114, 26);
            this.lblKotiosoite.TabIndex = 6;
            this.lblKotiosoite.Text = "Kotiosoite:";
            // 
            // tbKutsumanimi
            // 
            this.tbKutsumanimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKutsumanimi.Location = new System.Drawing.Point(196, 120);
            this.tbKutsumanimi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbKutsumanimi.Name = "tbKutsumanimi";
            this.tbKutsumanimi.Size = new System.Drawing.Size(167, 32);
            this.tbKutsumanimi.TabIndex = 5;
            this.tbKutsumanimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtunimet_KeyPress);
            this.tbKutsumanimi.Leave += new System.EventHandler(this.tbEtunimi_Leave);
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSukunimi.Location = new System.Drawing.Point(196, 164);
            this.tbSukunimi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(167, 32);
            this.tbSukunimi.TabIndex = 4;
            this.tbSukunimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtunimet_KeyPress);
            this.tbSukunimi.Leave += new System.EventHandler(this.tbEtunimi_Leave);
            // 
            // lblKutsumanimi
            // 
            this.lblKutsumanimi.AutoSize = true;
            this.lblKutsumanimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKutsumanimi.Location = new System.Drawing.Point(27, 128);
            this.lblKutsumanimi.Name = "lblKutsumanimi";
            this.lblKutsumanimi.Size = new System.Drawing.Size(140, 26);
            this.lblKutsumanimi.TabIndex = 3;
            this.lblKutsumanimi.Text = "Kutsumanimi";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSukunimi.Location = new System.Drawing.Point(29, 172);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(103, 26);
            this.lblSukunimi.TabIndex = 2;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // tbEtunimet
            // 
            this.tbEtunimet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEtunimet.Location = new System.Drawing.Point(196, 72);
            this.tbEtunimet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEtunimet.Name = "tbEtunimet";
            this.tbEtunimet.Size = new System.Drawing.Size(167, 32);
            this.tbEtunimet.TabIndex = 1;
            this.tbEtunimet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtunimet_KeyPress);
            this.tbEtunimet.Leave += new System.EventHandler(this.tbEtunimet_Leave);
            // 
            // lblEtunimet
            // 
            this.lblEtunimet.AutoSize = true;
            this.lblEtunimet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtunimet.Location = new System.Drawing.Point(29, 81);
            this.lblEtunimet.Name = "lblEtunimet";
            this.lblEtunimet.Size = new System.Drawing.Size(99, 26);
            this.lblEtunimet.TabIndex = 0;
            this.lblEtunimet.Text = "Etunimet";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toiminnotToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(916, 33);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toiminnotToolStripMenuItem
            // 
            this.toiminnotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTallenna,
            this.tsLopeta});
            this.toiminnotToolStripMenuItem.Name = "toiminnotToolStripMenuItem";
            this.toiminnotToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.toiminnotToolStripMenuItem.Text = "Toiminnot";
            // 
            // tsTallenna
            // 
            this.tsTallenna.Name = "tsTallenna";
            this.tsTallenna.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsTallenna.Size = new System.Drawing.Size(237, 34);
            this.tsTallenna.Text = "Tallenna";
            this.tsTallenna.Click += new System.EventHandler(this.tsTallenna_Click);
            // 
            // tsLopeta
            // 
            this.tsLopeta.Name = "tsLopeta";
            this.tsLopeta.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsLopeta.Size = new System.Drawing.Size(237, 34);
            this.tsLopeta.Text = "Lopeta";
            this.tsLopeta.Click += new System.EventHandler(this.tsLopeta_Click);
            // 
            // FrmHarjoitustyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 775);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHarjoitustyo";
            this.Text = "Harjoitustyö";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiedot)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTiedot;
        private System.Windows.Forms.TextBox tbYksikko;
        private System.Windows.Forms.Label lblYksikko;
        private System.Windows.Forms.TextBox tbTyonimike;
        private System.Windows.Forms.Label lblTyonimike;
        private System.Windows.Forms.Label lblPaattymispaiva;
        private System.Windows.Forms.DateTimePicker dtpPaattymispaiva;
        private System.Windows.Forms.DateTimePicker dtpAlkamispaiva;
        private System.Windows.Forms.Label lblAlkamispaiva;
        private System.Windows.Forms.Label lblToimisuhteenTiedot;
        private System.Windows.Forms.Label lblHenkilotiedot;
        private System.Windows.Forms.TextBox tbPostitoimipaikka;
        private System.Windows.Forms.TextBox tbPostinumero;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.Label lblKatuosoite;
        private System.Windows.Forms.Label lblPostinumero;
        private System.Windows.Forms.Label lblPostitoimipaikka;
        private System.Windows.Forms.TextBox tbHetu;
        private System.Windows.Forms.Label lblHetu;
        private System.Windows.Forms.Label lblKotiosoite;
        private System.Windows.Forms.TextBox tbKutsumanimi;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.Label lblKutsumanimi;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.TextBox tbEtunimet;
        private System.Windows.Forms.Label lblEtunimet;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toiminnotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsTallenna;
        private System.Windows.Forms.ToolStripMenuItem tsLopeta;
        private System.Windows.Forms.Button btnPoista;
    }
}

