namespace LintReservation.App
{
    partial class frmReservations
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtMasaSec = new System.Windows.Forms.TextBox();
            this.txtKisiSayisi = new System.Windows.Forms.TextBox();
            this.txtAcıklama = new System.Windows.Forms.TextBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.cboxMasaSec = new System.Windows.Forms.ComboBox();
            this.cboxKisiSayisi = new System.Windows.Forms.ComboBox();
            this.txtMasaID = new System.Windows.Forms.TextBox();
            this.btnRezervasyonAc = new System.Windows.Forms.Button();
            this.btnYeniMüsteri = new System.Windows.Forms.Button();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackgroundImage = global::LintReservation.App.Properties.Resources.Icon_Visitor_Return_300x300;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturn.Location = new System.Drawing.Point(65, 491);
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
            this.btnExit.Location = new System.Drawing.Point(18, 491);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 43);
            this.btnExit.TabIndex = 6;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(53, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Table :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(-1, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of People:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(-2, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description :";
            // 
            // txtTarih
            // 
            this.txtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarih.Location = new System.Drawing.Point(123, 111);
            this.txtTarih.Margin = new System.Windows.Forms.Padding(2);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(137, 26);
            this.txtTarih.TabIndex = 8;
            // 
            // txtMasaSec
            // 
            this.txtMasaSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMasaSec.Location = new System.Drawing.Point(123, 144);
            this.txtMasaSec.Margin = new System.Windows.Forms.Padding(2);
            this.txtMasaSec.Name = "txtMasaSec";
            this.txtMasaSec.ReadOnly = true;
            this.txtMasaSec.Size = new System.Drawing.Size(137, 26);
            this.txtMasaSec.TabIndex = 8;
            // 
            // txtKisiSayisi
            // 
            this.txtKisiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKisiSayisi.Location = new System.Drawing.Point(123, 178);
            this.txtKisiSayisi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.ReadOnly = true;
            this.txtKisiSayisi.Size = new System.Drawing.Size(137, 26);
            this.txtKisiSayisi.TabIndex = 8;
            // 
            // txtAcıklama
            // 
            this.txtAcıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAcıklama.Location = new System.Drawing.Point(123, 211);
            this.txtAcıklama.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcıklama.Multiline = true;
            this.txtAcıklama.Name = "txtAcıklama";
            this.txtAcıklama.Size = new System.Drawing.Size(173, 136);
            this.txtAcıklama.TabIndex = 8;
            // 
            // dtTarih
            // 
            this.dtTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Location = new System.Drawing.Point(263, 111);
            this.dtTarih.Margin = new System.Windows.Forms.Padding(2);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(32, 20);
            this.dtTarih.TabIndex = 9;
            this.dtTarih.ValueChanged += new System.EventHandler(this.dtTarih_ValueChanged);
            this.dtTarih.Enter += new System.EventHandler(this.dtTarih_Enter);
            this.dtTarih.MouseEnter += new System.EventHandler(this.dtTarih_MouseEnter);
            this.dtTarih.MouseLeave += new System.EventHandler(this.dtTarih_MouseLeave);
            // 
            // cboxMasaSec
            // 
            this.cboxMasaSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxMasaSec.FormattingEnabled = true;
            this.cboxMasaSec.Location = new System.Drawing.Point(261, 143);
            this.cboxMasaSec.Margin = new System.Windows.Forms.Padding(2);
            this.cboxMasaSec.Name = "cboxMasaSec";
            this.cboxMasaSec.Size = new System.Drawing.Size(92, 28);
            this.cboxMasaSec.TabIndex = 10;
            this.cboxMasaSec.SelectedIndexChanged += new System.EventHandler(this.cboxMasaSec_SelectedIndexChanged);
            this.cboxMasaSec.MouseEnter += new System.EventHandler(this.cboxMasaSec_MouseEnter);
            this.cboxMasaSec.MouseLeave += new System.EventHandler(this.cboxMasaSec_MouseLeave);
            // 
            // cboxKisiSayisi
            // 
            this.cboxKisiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxKisiSayisi.FormattingEnabled = true;
            this.cboxKisiSayisi.Location = new System.Drawing.Point(261, 176);
            this.cboxKisiSayisi.Margin = new System.Windows.Forms.Padding(2);
            this.cboxKisiSayisi.Name = "cboxKisiSayisi";
            this.cboxKisiSayisi.Size = new System.Drawing.Size(35, 28);
            this.cboxKisiSayisi.TabIndex = 10;
            this.cboxKisiSayisi.SelectedIndexChanged += new System.EventHandler(this.cboxKisiSayisi_SelectedIndexChanged);
            this.cboxKisiSayisi.MouseEnter += new System.EventHandler(this.cboxKisiSayisi_MouseEnter);
            this.cboxKisiSayisi.MouseLeave += new System.EventHandler(this.cboxKisiSayisi_MouseLeave);
            // 
            // txtMasaID
            // 
            this.txtMasaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMasaID.Location = new System.Drawing.Point(396, 142);
            this.txtMasaID.Margin = new System.Windows.Forms.Padding(2);
            this.txtMasaID.Name = "txtMasaID";
            this.txtMasaID.Size = new System.Drawing.Size(41, 28);
            this.txtMasaID.TabIndex = 8;
            this.txtMasaID.Visible = false;
            // 
            // btnRezervasyonAc
            // 
            this.btnRezervasyonAc.BackColor = System.Drawing.Color.Transparent;
            this.btnRezervasyonAc.BackgroundImage = global::LintReservation.App.Properties.Resources.create_reservat;
            this.btnRezervasyonAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRezervasyonAc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezervasyonAc.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonAc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRezervasyonAc.Location = new System.Drawing.Point(614, 384);
            this.btnRezervasyonAc.Margin = new System.Windows.Forms.Padding(2);
            this.btnRezervasyonAc.Name = "btnRezervasyonAc";
            this.btnRezervasyonAc.Size = new System.Drawing.Size(200, 98);
            this.btnRezervasyonAc.TabIndex = 11;
            this.btnRezervasyonAc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRezervasyonAc.UseVisualStyleBackColor = false;
            this.btnRezervasyonAc.Click += new System.EventHandler(this.btnRezervasyonAc_Click);
            // 
            // btnYeniMüsteri
            // 
            this.btnYeniMüsteri.BackColor = System.Drawing.Color.Transparent;
            this.btnYeniMüsteri.BackgroundImage = global::LintReservation.App.Properties.Resources.newcustomer;
            this.btnYeniMüsteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeniMüsteri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeniMüsteri.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniMüsteri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYeniMüsteri.Location = new System.Drawing.Point(818, 383);
            this.btnYeniMüsteri.Margin = new System.Windows.Forms.Padding(2);
            this.btnYeniMüsteri.Name = "btnYeniMüsteri";
            this.btnYeniMüsteri.Size = new System.Drawing.Size(200, 98);
            this.btnYeniMüsteri.TabIndex = 13;
            this.btnYeniMüsteri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeniMüsteri.UseVisualStyleBackColor = false;
            this.btnYeniMüsteri.Click += new System.EventHandler(this.btnYeniMüsteri_Click);
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.BackColor = System.Drawing.Color.Black;
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvMusteriler.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.HideSelection = false;
            this.lvMusteriler.Location = new System.Drawing.Point(462, 58);
            this.lvMusteriler.Margin = new System.Windows.Forms.Padding(2);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(731, 321);
            this.lvMusteriler.TabIndex = 14;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Customer\'s Name";
            this.columnHeader2.Width = 184;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Customer\'s Surname";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone";
            this.columnHeader4.Width = 148;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Address";
            this.columnHeader5.Width = 239;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "E-Mail";
            this.columnHeader6.Width = 190;
            // 
            // frmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LintReservation.App.Properties.Resources.bgimagetable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 547);
            this.Controls.Add(this.lvMusteriler);
            this.Controls.Add(this.btnRezervasyonAc);
            this.Controls.Add(this.btnYeniMüsteri);
            this.Controls.Add(this.cboxKisiSayisi);
            this.Controls.Add(this.cboxMasaSec);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.txtAcıklama);
            this.Controls.Add(this.txtKisiSayisi);
            this.Controls.Add(this.txtMasaSec);
            this.Controls.Add(this.txtMasaID);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRezervasyon";
            this.Load += new System.EventHandler(this.frmRezervasyon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtMasaSec;
        private System.Windows.Forms.TextBox txtKisiSayisi;
        private System.Windows.Forms.TextBox txtAcıklama;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ComboBox cboxMasaSec;
        private System.Windows.Forms.ComboBox cboxKisiSayisi;
        private System.Windows.Forms.TextBox txtMasaID;
        private System.Windows.Forms.Button btnRezervasyonAc;
        private System.Windows.Forms.Button btnYeniMüsteri;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}