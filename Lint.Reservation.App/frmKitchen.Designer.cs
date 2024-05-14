namespace LintReservation.App
{
    partial class frmKitchen
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lvUrunListe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlEklemeİslemleri = new System.Windows.Forms.Panel();
            this.txtKategoriID = new System.Windows.Forms.TextBox();
            this.cboxKategori = new System.Windows.Forms.ComboBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUrunArama = new System.Windows.Forms.Label();
            this.txtUrunArama = new System.Windows.Forms.TextBox();
            this.pnlEklemeİslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackgroundImage = global::LintReservation.App.Properties.Resources.Icon_Visitor_Return_300x300;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Location = new System.Drawing.Point(88, 490);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(44, 44);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::LintReservation.App.Properties.Resources.exit_icons_201;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(40, 490);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lvUrunListe
            // 
            this.lvUrunListe.BackColor = System.Drawing.Color.Black;
            this.lvUrunListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader9});
            this.lvUrunListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvUrunListe.ForeColor = System.Drawing.SystemColors.Window;
            this.lvUrunListe.FullRowSelect = true;
            this.lvUrunListe.HideSelection = false;
            this.lvUrunListe.Location = new System.Drawing.Point(166, 306);
            this.lvUrunListe.Margin = new System.Windows.Forms.Padding(2);
            this.lvUrunListe.Name = "lvUrunListe";
            this.lvUrunListe.Size = new System.Drawing.Size(663, 228);
            this.lvUrunListe.TabIndex = 3;
            this.lvUrunListe.UseCompatibleStateImageBehavior = false;
            this.lvUrunListe.View = System.Windows.Forms.View.Details;
            this.lvUrunListe.SelectedIndexChanged += new System.EventHandler(this.lvUrunListe_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Urun ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "KategoriID";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Category Name";
            this.columnHeader3.Width = 273;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Product Name";
            this.columnHeader4.Width = 325;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Price";
            this.columnHeader9.Width = 192;
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImage = global::LintReservation.App.Properties.Resources.addP;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Location = new System.Drawing.Point(166, 227);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(163, 75);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackgroundImage = global::LintReservation.App.Properties.Resources.changingP;
            this.btnDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDegistir.Location = new System.Drawing.Point(333, 227);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(2);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(163, 75);
            this.btnDegistir.TabIndex = 4;
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Visible = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::LintReservation.App.Properties.Resources.deleteP;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(666, 227);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(163, 75);
            this.btnSil.TabIndex = 4;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::LintReservation.App.Properties.Resources.findP;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(500, 227);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 75);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlEklemeİslemleri
            // 
            this.pnlEklemeİslemleri.BackColor = System.Drawing.Color.Transparent;
            this.pnlEklemeİslemleri.Controls.Add(this.txtKategoriID);
            this.pnlEklemeİslemleri.Controls.Add(this.cboxKategori);
            this.pnlEklemeİslemleri.Controls.Add(this.txtFiyat);
            this.pnlEklemeİslemleri.Controls.Add(this.txtAd);
            this.pnlEklemeİslemleri.Controls.Add(this.label3);
            this.pnlEklemeİslemleri.Controls.Add(this.label2);
            this.pnlEklemeİslemleri.Controls.Add(this.label1);
            this.pnlEklemeİslemleri.Location = new System.Drawing.Point(216, 10);
            this.pnlEklemeİslemleri.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEklemeİslemleri.Name = "pnlEklemeİslemleri";
            this.pnlEklemeİslemleri.Size = new System.Drawing.Size(584, 158);
            this.pnlEklemeİslemleri.TabIndex = 5;
            // 
            // txtKategoriID
            // 
            this.txtKategoriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriID.Location = new System.Drawing.Point(440, 33);
            this.txtKategoriID.Margin = new System.Windows.Forms.Padding(2);
            this.txtKategoriID.Name = "txtKategoriID";
            this.txtKategoriID.Size = new System.Drawing.Size(26, 28);
            this.txtKategoriID.TabIndex = 3;
            // 
            // cboxKategori
            // 
            this.cboxKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxKategori.FormattingEnabled = true;
            this.cboxKategori.Location = new System.Drawing.Point(230, 33);
            this.cboxKategori.Margin = new System.Windows.Forms.Padding(2);
            this.cboxKategori.Name = "cboxKategori";
            this.cboxKategori.Size = new System.Drawing.Size(205, 28);
            this.cboxKategori.TabIndex = 2;
            this.cboxKategori.SelectedIndexChanged += new System.EventHandler(this.cboxKategori_SelectedIndexChanged);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(230, 106);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(205, 28);
            this.txtFiyat.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(230, 69);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(205, 28);
            this.txtAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(75, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(75, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Food Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(75, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Category:";
            // 
            // lblUrunArama
            // 
            this.lblUrunArama.AutoSize = true;
            this.lblUrunArama.BackColor = System.Drawing.Color.Transparent;
            this.lblUrunArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunArama.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUrunArama.Location = new System.Drawing.Point(138, 183);
            this.lblUrunArama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrunArama.Name = "lblUrunArama";
            this.lblUrunArama.Size = new System.Drawing.Size(316, 24);
            this.lblUrunArama.TabIndex = 0;
            this.lblUrunArama.Text = "The Product You Want to Search";
            this.lblUrunArama.Visible = false;
            // 
            // txtUrunArama
            // 
            this.txtUrunArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunArama.Location = new System.Drawing.Point(458, 180);
            this.txtUrunArama.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunArama.Name = "txtUrunArama";
            this.txtUrunArama.Size = new System.Drawing.Size(205, 28);
            this.txtUrunArama.TabIndex = 1;
            this.txtUrunArama.Visible = false;
            this.txtUrunArama.TextChanged += new System.EventHandler(this.txtUrunArama_TextChanged);
            this.txtUrunArama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunArama_KeyPress);
            // 
            // frmKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LintReservation.App.Properties.Resources.backimagemutfak;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 555);
            this.Controls.Add(this.txtUrunArama);
            this.Controls.Add(this.lblUrunArama);
            this.Controls.Add(this.pnlEklemeİslemleri);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lvUrunListe);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKitchen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMutfak";
            this.Load += new System.EventHandler(this.frmMutfak_Load);
            this.pnlEklemeİslemleri.ResumeLayout(false);
            this.pnlEklemeİslemleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lvUrunListe;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlEklemeİslemleri;
        private System.Windows.Forms.ComboBox cboxKategori;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUrunArama;
        private System.Windows.Forms.TextBox txtUrunArama;
        private System.Windows.Forms.TextBox txtKategoriID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}