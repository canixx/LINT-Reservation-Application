namespace LintReservation.App
{
    partial class frmSettings
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
            System.Windows.Forms.ColumnHeader columnHeader1;
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.cbGorevler = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAdı = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.gbox2 = new System.Windows.Forms.GroupBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtIDPersonel = new System.Windows.Forms.TextBox();
            this.txtGorevID = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cboxGorevi = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblGörevi = new System.Windows.Forms.Label();
            this.lblYeniSifretekrar2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeğiştir2 = new System.Windows.Forms.Button();
            this.lblYeniSİfre2 = new System.Windows.Forms.Label();
            this.txtYeniSifreT2 = new System.Windows.Forms.TextBox();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtYeniSİfre2 = new System.Windows.Forms.TextBox();
            this.lvPersoneller = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblGirisYapan = new System.Windows.Forms.Label();
            this.gbox4 = new System.Windows.Forms.GroupBox();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbox1.SuspendLayout();
            this.gbox2.SuspendLayout();
            this.gbox3.SuspendLayout();
            this.gbox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Personel ID";
            columnHeader1.Width = 2;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackgroundImage = global::LintReservation.App.Properties.Resources.Icon_Visitor_Return_300x300;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturn.Location = new System.Drawing.Point(60, 552);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(43, 43);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::LintReservation.App.Properties.Resources.exit_icons_201;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(13, 552);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 43);
            this.btnExit.TabIndex = 6;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbox1
            // 
            this.gbox1.BackColor = System.Drawing.Color.Transparent;
            this.gbox1.Controls.Add(this.button1);
            this.gbox1.Controls.Add(this.txtPersonelID);
            this.gbox1.Controls.Add(this.cbGorevler);
            this.gbox1.Controls.Add(this.label5);
            this.gbox1.Controls.Add(this.label4);
            this.gbox1.Controls.Add(this.txtYeniSifre);
            this.gbox1.Controls.Add(this.txtYeniSifreTekrar);
            this.gbox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbox1.Location = new System.Drawing.Point(9, 62);
            this.gbox1.Margin = new System.Windows.Forms.Padding(2);
            this.gbox1.Name = "gbox1";
            this.gbox1.Padding = new System.Windows.Forms.Padding(2);
            this.gbox1.Size = new System.Drawing.Size(319, 292);
            this.gbox1.TabIndex = 7;
            this.gbox1.TabStop = false;
            this.gbox1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::LintReservation.App.Properties.Resources.changing;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(88, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 75);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(282, 80);
            this.txtPersonelID.Margin = new System.Windows.Forms.Padding(2);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(35, 28);
            this.txtPersonelID.TabIndex = 3;
            // 
            // cbGorevler
            // 
            this.cbGorevler.FormattingEnabled = true;
            this.cbGorevler.Location = new System.Drawing.Point(154, 80);
            this.cbGorevler.Margin = new System.Windows.Forms.Padding(2);
            this.cbGorevler.Name = "cbGorevler";
            this.cbGorevler.Size = new System.Drawing.Size(124, 30);
            this.cbGorevler.TabIndex = 2;
            this.cbGorevler.SelectedIndexChanged += new System.EventHandler(this.cbGorevler_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "New Password Again";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "New Password";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(156, 115);
            this.txtYeniSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(124, 28);
            this.txtYeniSifre.TabIndex = 0;
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(156, 148);
            this.txtYeniSifreTekrar.Margin = new System.Windows.Forms.Padding(2);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(124, 28);
            this.txtYeniSifreTekrar.TabIndex = 0;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.White;
            this.lblSoyad.Location = new System.Drawing.Point(100, 72);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(87, 24);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Surname";
            // 
            // lblAdı
            // 
            this.lblAdı.AutoSize = true;
            this.lblAdı.ForeColor = System.Drawing.Color.White;
            this.lblAdı.Location = new System.Drawing.Point(103, 37);
            this.lblAdı.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdı.Name = "lblAdı";
            this.lblAdı.Size = new System.Drawing.Size(61, 24);
            this.lblAdı.TabIndex = 1;
            this.lblAdı.Text = "Name";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(240, 67);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(124, 28);
            this.txtSoyad.TabIndex = 0;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(240, 35);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(124, 28);
            this.txtAd.TabIndex = 0;
            // 
            // gbox2
            // 
            this.gbox2.BackColor = System.Drawing.Color.Transparent;
            this.gbox2.Controls.Add(this.btnYeni);
            this.gbox2.Controls.Add(this.txtIDPersonel);
            this.gbox2.Controls.Add(this.txtGorevID);
            this.gbox2.Controls.Add(this.btnKaydet);
            this.gbox2.Controls.Add(this.cboxGorevi);
            this.gbox2.Controls.Add(this.btnSil);
            this.gbox2.Controls.Add(this.lblGörevi);
            this.gbox2.Controls.Add(this.lblYeniSifretekrar2);
            this.gbox2.Controls.Add(this.label2);
            this.gbox2.Controls.Add(this.lblSoyad);
            this.gbox2.Controls.Add(this.btnDeğiştir2);
            this.gbox2.Controls.Add(this.lblYeniSİfre2);
            this.gbox2.Controls.Add(this.txtYeniSifreT2);
            this.gbox2.Controls.Add(this.lblAdı);
            this.gbox2.Controls.Add(this.txtKullanıcıAdı);
            this.gbox2.Controls.Add(this.txtYeniSİfre2);
            this.gbox2.Controls.Add(this.txtSoyad);
            this.gbox2.Controls.Add(this.txtAd);
            this.gbox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbox2.Location = new System.Drawing.Point(332, 62);
            this.gbox2.Margin = new System.Windows.Forms.Padding(2);
            this.gbox2.Name = "gbox2";
            this.gbox2.Padding = new System.Windows.Forms.Padding(2);
            this.gbox2.Size = new System.Drawing.Size(459, 378);
            this.gbox2.TabIndex = 7;
            this.gbox2.TabStop = false;
            this.gbox2.Visible = false;
            // 
            // btnYeni
            // 
            this.btnYeni.BackgroundImage = global::LintReservation.App.Properties.Resources.newEMP;
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeni.Location = new System.Drawing.Point(73, 246);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(2);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(170, 58);
            this.btnYeni.TabIndex = 4;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtIDPersonel
            // 
            this.txtIDPersonel.Location = new System.Drawing.Point(368, 35);
            this.txtIDPersonel.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDPersonel.Name = "txtIDPersonel";
            this.txtIDPersonel.Size = new System.Drawing.Size(35, 28);
            this.txtIDPersonel.TabIndex = 3;
            // 
            // txtGorevID
            // 
            this.txtGorevID.Location = new System.Drawing.Point(368, 196);
            this.txtGorevID.Margin = new System.Windows.Forms.Padding(2);
            this.txtGorevID.Name = "txtGorevID";
            this.txtGorevID.Size = new System.Drawing.Size(35, 28);
            this.txtGorevID.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::LintReservation.App.Properties.Resources.save;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Location = new System.Drawing.Point(248, 246);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(170, 58);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cboxGorevi
            // 
            this.cboxGorevi.FormattingEnabled = true;
            this.cboxGorevi.Location = new System.Drawing.Point(240, 196);
            this.cboxGorevi.Margin = new System.Windows.Forms.Padding(2);
            this.cboxGorevi.Name = "cboxGorevi";
            this.cboxGorevi.Size = new System.Drawing.Size(124, 30);
            this.cboxGorevi.TabIndex = 2;
            this.cboxGorevi.SelectedIndexChanged += new System.EventHandler(this.cboxGorevi_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::LintReservation.App.Properties.Resources.SSSS;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(73, 310);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(170, 58);
            this.btnSil.TabIndex = 4;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblGörevi
            // 
            this.lblGörevi.AutoSize = true;
            this.lblGörevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGörevi.ForeColor = System.Drawing.Color.White;
            this.lblGörevi.Location = new System.Drawing.Point(103, 202);
            this.lblGörevi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGörevi.Name = "lblGörevi";
            this.lblGörevi.Size = new System.Drawing.Size(47, 24);
            this.lblGörevi.TabIndex = 1;
            this.lblGörevi.Text = "Duty";
            // 
            // lblYeniSifretekrar2
            // 
            this.lblYeniSifretekrar2.AutoSize = true;
            this.lblYeniSifretekrar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniSifretekrar2.ForeColor = System.Drawing.Color.White;
            this.lblYeniSifretekrar2.Location = new System.Drawing.Point(103, 173);
            this.lblYeniSifretekrar2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYeniSifretekrar2.Name = "lblYeniSifretekrar2";
            this.lblYeniSifretekrar2.Size = new System.Drawing.Size(135, 16);
            this.lblYeniSifretekrar2.TabIndex = 1;
            this.lblYeniSifretekrar2.Text = "New Password Again";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // btnDeğiştir2
            // 
            this.btnDeğiştir2.BackgroundImage = global::LintReservation.App.Properties.Resources.changing;
            this.btnDeğiştir2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeğiştir2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeğiştir2.Location = new System.Drawing.Point(248, 310);
            this.btnDeğiştir2.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeğiştir2.Name = "btnDeğiştir2";
            this.btnDeğiştir2.Size = new System.Drawing.Size(170, 58);
            this.btnDeğiştir2.TabIndex = 4;
            this.btnDeğiştir2.UseVisualStyleBackColor = true;
            this.btnDeğiştir2.Click += new System.EventHandler(this.btnDeğiştir2_Click);
            // 
            // lblYeniSİfre2
            // 
            this.lblYeniSİfre2.AutoSize = true;
            this.lblYeniSİfre2.ForeColor = System.Drawing.Color.White;
            this.lblYeniSİfre2.Location = new System.Drawing.Point(103, 136);
            this.lblYeniSİfre2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYeniSİfre2.Name = "lblYeniSİfre2";
            this.lblYeniSİfre2.Size = new System.Drawing.Size(136, 24);
            this.lblYeniSİfre2.TabIndex = 1;
            this.lblYeniSİfre2.Text = "New Password";
            // 
            // txtYeniSifreT2
            // 
            this.txtYeniSifreT2.Location = new System.Drawing.Point(240, 166);
            this.txtYeniSifreT2.Margin = new System.Windows.Forms.Padding(2);
            this.txtYeniSifreT2.Name = "txtYeniSifreT2";
            this.txtYeniSifreT2.ReadOnly = true;
            this.txtYeniSifreT2.Size = new System.Drawing.Size(124, 28);
            this.txtYeniSifreT2.TabIndex = 0;
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(240, 100);
            this.txtKullanıcıAdı.Margin = new System.Windows.Forms.Padding(2);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(124, 28);
            this.txtKullanıcıAdı.TabIndex = 0;
            // 
            // txtYeniSİfre2
            // 
            this.txtYeniSİfre2.Location = new System.Drawing.Point(240, 133);
            this.txtYeniSİfre2.Margin = new System.Windows.Forms.Padding(2);
            this.txtYeniSİfre2.Name = "txtYeniSİfre2";
            this.txtYeniSİfre2.ReadOnly = true;
            this.txtYeniSİfre2.Size = new System.Drawing.Size(124, 28);
            this.txtYeniSİfre2.TabIndex = 0;
            // 
            // lvPersoneller
            // 
            this.lvPersoneller.BackColor = System.Drawing.Color.Silver;
            this.lvPersoneller.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvPersoneller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvPersoneller.FullRowSelect = true;
            this.lvPersoneller.HideSelection = false;
            this.lvPersoneller.Location = new System.Drawing.Point(10, 17);
            this.lvPersoneller.Margin = new System.Windows.Forms.Padding(2);
            this.lvPersoneller.Name = "lvPersoneller";
            this.lvPersoneller.Size = new System.Drawing.Size(375, 158);
            this.lvPersoneller.TabIndex = 8;
            this.lvPersoneller.UseCompatibleStateImageBehavior = false;
            this.lvPersoneller.View = System.Windows.Forms.View.Details;
            this.lvPersoneller.SelectedIndexChanged += new System.EventHandler(this.lvPersoneller_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Personel Gorev ID";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Duty";
            this.columnHeader3.Width = 158;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 155;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Surname";
            this.columnHeader5.Width = 175;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kullanıcı Adı";
            // 
            // gbox3
            // 
            this.gbox3.BackColor = System.Drawing.Color.Transparent;
            this.gbox3.Controls.Add(this.button6);
            this.gbox3.Controls.Add(this.label1);
            this.gbox3.Controls.Add(this.label3);
            this.gbox3.Controls.Add(this.textBox5);
            this.gbox3.Controls.Add(this.textBox6);
            this.gbox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbox3.Location = new System.Drawing.Point(807, 62);
            this.gbox3.Margin = new System.Windows.Forms.Padding(2);
            this.gbox3.Name = "gbox3";
            this.gbox3.Padding = new System.Windows.Forms.Padding(2);
            this.gbox3.Size = new System.Drawing.Size(319, 292);
            this.gbox3.TabIndex = 7;
            this.gbox3.TabStop = false;
            this.gbox3.Visible = false;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::LintReservation.App.Properties.Resources.changing;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(92, 171);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(189, 75);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Password Again";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "New Password";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(158, 117);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(124, 28);
            this.textBox5.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(158, 84);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(124, 28);
            this.textBox6.TabIndex = 0;
            // 
            // lblGirisYapan
            // 
            this.lblGirisYapan.AutoSize = true;
            this.lblGirisYapan.BackColor = System.Drawing.Color.Transparent;
            this.lblGirisYapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisYapan.ForeColor = System.Drawing.Color.Red;
            this.lblGirisYapan.Location = new System.Drawing.Point(9, 24);
            this.lblGirisYapan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGirisYapan.Name = "lblGirisYapan";
            this.lblGirisYapan.Size = new System.Drawing.Size(110, 24);
            this.lblGirisYapan.TabIndex = 9;
            this.lblGirisYapan.Text = "Logged in:";
            // 
            // gbox4
            // 
            this.gbox4.BackColor = System.Drawing.Color.Transparent;
            this.gbox4.Controls.Add(this.lvPersoneller);
            this.gbox4.Location = new System.Drawing.Point(366, 444);
            this.gbox4.Margin = new System.Windows.Forms.Padding(2);
            this.gbox4.Name = "gbox4";
            this.gbox4.Padding = new System.Windows.Forms.Padding(2);
            this.gbox4.Size = new System.Drawing.Size(401, 184);
            this.gbox4.TabIndex = 10;
            this.gbox4.TabStop = false;
            this.gbox4.Visible = false;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LintReservation.App.Properties.Resources.backimageayarlar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1135, 639);
            this.Controls.Add(this.gbox4);
            this.Controls.Add(this.lblGirisYapan);
            this.Controls.Add(this.gbox2);
            this.Controls.Add(this.gbox3);
            this.Controls.Add(this.gbox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAyarlar";
            this.Load += new System.EventHandler(this.frmAyarlar_Load);
            this.gbox1.ResumeLayout(false);
            this.gbox1.PerformLayout();
            this.gbox2.ResumeLayout(false);
            this.gbox2.PerformLayout();
            this.gbox3.ResumeLayout(false);
            this.gbox3.PerformLayout();
            this.gbox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbGorevler;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAdı;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.GroupBox gbox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtGorevID;
        private System.Windows.Forms.ComboBox cboxGorevi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblGörevi;
        private System.Windows.Forms.Label lblYeniSifretekrar2;
        private System.Windows.Forms.Button btnDeğiştir2;
        private System.Windows.Forms.Label lblYeniSİfre2;
        private System.Windows.Forms.TextBox txtYeniSifreT2;
        private System.Windows.Forms.TextBox txtYeniSİfre2;
        private System.Windows.Forms.ListView lvPersoneller;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox gbox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblGirisYapan;
        private System.Windows.Forms.GroupBox gbox4;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtIDPersonel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnKaydet;
    }
}