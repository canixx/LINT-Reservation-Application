namespace LintReservation.App
{
    partial class frmAccount
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
            this.cboxDuty = new System.Windows.Forms.ComboBox();
            this.lblGörevi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblYeniSİfre2 = new System.Windows.Forms.Label();
            this.lblAdı = new System.Windows.Forms.Label();
            this.txtName = new LintReservationCustomControls.MyTextBox();
            this.txtSurname = new LintReservationCustomControls.MyTextBox();
            this.txtUsername = new LintReservationCustomControls.MyTextBox();
            this.txtPass = new LintReservationCustomControls.MyTextBox();
            this.btnNew = new System.Windows.Forms.Button();
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
            this.btnReturn.Location = new System.Drawing.Point(58, 437);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(43, 43);
            this.btnReturn.TabIndex = 7;
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
            this.btnExit.Location = new System.Drawing.Point(11, 437);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 43);
            this.btnExit.TabIndex = 8;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboxDuty
            // 
            this.cboxDuty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxDuty.FormattingEnabled = true;
            this.cboxDuty.Location = new System.Drawing.Point(396, 183);
            this.cboxDuty.Margin = new System.Windows.Forms.Padding(2);
            this.cboxDuty.Name = "cboxDuty";
            this.cboxDuty.Size = new System.Drawing.Size(133, 28);
            this.cboxDuty.TabIndex = 20;
            // 
            // lblGörevi
            // 
            this.lblGörevi.AutoSize = true;
            this.lblGörevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGörevi.ForeColor = System.Drawing.Color.Black;
            this.lblGörevi.Location = new System.Drawing.Point(244, 182);
            this.lblGörevi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGörevi.Name = "lblGörevi";
            this.lblGörevi.Size = new System.Drawing.Size(56, 25);
            this.lblGörevi.TabIndex = 14;
            this.lblGörevi.Text = "Duty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(244, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblSoyad.Location = new System.Drawing.Point(244, 123);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(98, 25);
            this.lblSoyad.TabIndex = 17;
            this.lblSoyad.Text = "Surname";
            // 
            // lblYeniSİfre2
            // 
            this.lblYeniSİfre2.AutoSize = true;
            this.lblYeniSİfre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniSİfre2.ForeColor = System.Drawing.Color.Black;
            this.lblYeniSİfre2.Location = new System.Drawing.Point(244, 303);
            this.lblYeniSİfre2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYeniSİfre2.Name = "lblYeniSİfre2";
            this.lblYeniSİfre2.Size = new System.Drawing.Size(106, 25);
            this.lblYeniSİfre2.TabIndex = 18;
            this.lblYeniSİfre2.Text = "Password";
            // 
            // lblAdı
            // 
            this.lblAdı.AutoSize = true;
            this.lblAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdı.ForeColor = System.Drawing.Color.Black;
            this.lblAdı.Location = new System.Drawing.Point(244, 64);
            this.lblAdı.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdı.Name = "lblAdı";
            this.lblAdı.Size = new System.Drawing.Size(68, 25);
            this.lblAdı.TabIndex = 19;
            this.lblAdı.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.CalismaModu = LintReservationCustomControls.MyTextBox.WorkMode.Harf;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(396, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 26);
            this.txtName.TabIndex = 21;
            // 
            // txtSurname
            // 
            this.txtSurname.CalismaModu = LintReservationCustomControls.MyTextBox.WorkMode.Harf;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.Location = new System.Drawing.Point(396, 124);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(133, 26);
            this.txtSurname.TabIndex = 22;
            // 
            // txtUsername
            // 
            this.txtUsername.CalismaModu = LintReservationCustomControls.MyTextBox.WorkMode.Harf;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.Location = new System.Drawing.Point(396, 243);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(133, 26);
            this.txtUsername.TabIndex = 23;
            // 
            // txtPass
            // 
            this.txtPass.CalismaModu = LintReservationCustomControls.MyTextBox.WorkMode.Rakam;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPass.Location = new System.Drawing.Point(396, 303);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(133, 26);
            this.txtPass.TabIndex = 24;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackgroundImage = global::LintReservation.App.Properties.Resources.newEMP;
            this.btnNew.Location = new System.Drawing.Point(355, 364);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(174, 60);
            this.btnNew.TabIndex = 25;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LintReservation.App.Properties.Resources.bgimagetable3;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboxDuty);
            this.Controls.Add(this.lblGörevi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblYeniSİfre2);
            this.Controls.Add(this.lblAdı);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccount";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboxDuty;
        private System.Windows.Forms.Label lblGörevi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblYeniSİfre2;
        private System.Windows.Forms.Label lblAdı;
        private LintReservationCustomControls.MyTextBox txtName;
        private LintReservationCustomControls.MyTextBox txtSurname;
        private LintReservationCustomControls.MyTextBox txtUsername;
        private LintReservationCustomControls.MyTextBox txtPass;
        private System.Windows.Forms.Button btnNew;
    }
}