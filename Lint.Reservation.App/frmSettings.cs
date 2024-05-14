using LintReservation.BLL;
using LintReservation.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LintReservation.App
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }
        EmployeeBL pbl = new EmployeeBL();
        LintReservationBL hbl = new LintReservationBL();
        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            string gorev = pbl.PersonelGorevTanım(General.DutyID);
            if (gorev == "Boss")
            {
                cbGorevler.DisplayMember = "AD";
                cbGorevler.ValueMember = "ID";
                cbGorevler.DataSource = hbl.PersonelGorevleriniGetir();
                cboxGorevi.DisplayMember = "GOREV";
                cboxGorevi.ValueMember = "ID";
                cboxGorevi.DataSource = pbl.PersonelGorevleriniGetir();
                Listele();
                btnYeni.Enabled = true;
                btnSil.Enabled = false;
                btnDeğiştir2.Enabled = false;
                btnKaydet.Enabled = false;
                gbox1.Visible = true;
                gbox2.Visible = true;
                gbox3.Visible = false;
                gbox4.Visible = true;
                txtYeniSİfre2.ReadOnly = true;
                txtYeniSifreT2.ReadOnly = true;
                lblGirisYapan.Text = "Boss/Authority Unlimited/User:" + pbl.PersonelisminiGetir(General.EmployeeID);
            }
            else
            {
                gbox1.Visible = false;
                gbox2.Visible = false;
                gbox3.Visible = true;
                gbox4.Visible = false;
                lblGirisYapan.Text = "Authority Limited/User:" + pbl.PersonelisminiGetir(General.EmployeeID);

            }

        }
        void Listele()
        {
            List<EmployeeDutys> lst = pbl.PersonelBilgileriniGetir();
            for (int i = 0; i < lst.Count; i++)
            {
                lvPersoneller.Items.Add((lst[i].ID1).ToString());
                lvPersoneller.Items[i].SubItems.Add(lst[i].DutyID.ToString());
                lvPersoneller.Items[i].SubItems.Add(lst[i].DutyName.ToString());
                lvPersoneller.Items[i].SubItems.Add(lst[i].Name.ToString());
                lvPersoneller.Items[i].SubItems.Add(lst[i].Surname.ToString());
                lvPersoneller.Items[i].SubItems.Add(lst[i].Username.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text.Trim() != "" || txtYeniSifreTekrar.Text.Trim() != "")
            {
                if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
                {
                    if (txtPersonelID.Text != "")
                    {
                        bool sonuc = pbl.PersonelSifreDegistir(Convert.ToInt32(txtPersonelID.Text), Convert.ToInt32(txtYeniSifre.Text));
                        if (sonuc)
                        {
                            MessageBox.Show("Password Change Process Completed Successfully");
                            LintReservationBL habl = new LintReservationBL();
                            EmployeeActions peh = new EmployeeActions();
                            peh.EmployeeID = General.EmployeeID;
                            peh.Operation = "The password was changed by";
                            peh.Date = DateTime.Now;
                            habl.PersonelHareketleriniKaydet(peh);
                            txtYeniSifre.Text = "";
                            txtYeniSifreTekrar.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select Employee");
                    }

                }
                else
                {
                    MessageBox.Show("Passwords Are Not the Same");
                }

            }
            else
            {
                MessageBox.Show("Do not leave the password field blank");
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnYeni.Enabled = false;
            btnKaydet.Enabled = true;
            btnDeğiştir2.Enabled = false;
            btnSil.Enabled = false;
            txtYeniSİfre2.ReadOnly = false;
            txtYeniSifreT2.ReadOnly = false;

        }

        private void cbGorevler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPersonelID.Text = pbl.txtIDyazdırma(cbGorevler.Text).ToString();
        }

        private void cboxGorevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGorevID.Text = pbl.txtIDyazdırmaforGorev(cboxGorevi.Text).ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    pbl.PersonelSilmekİçinGerekli(Convert.ToInt32(lvPersoneller.SelectedItems[0].Text));
                    bool sonuc = pbl.PersonelSil(Convert.ToInt32(lvPersoneller.SelectedItems[0].Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Record Deleted Successfully");
                        LintReservationBL hll = new LintReservationBL();
                        EmployeeActions hlll = new EmployeeActions();
                        hlll.EmployeeID = General.EmployeeID;
                        hlll.Operation = "Staff Deleted by";
                        hlll.Date = DateTime.Now;
                        hll.PersonelHareketleriniKaydet(hlll);
                        temizleme();
                        Listele();
                    }
                    else
                    {
                        MessageBox.Show("An Error Occurred While Deleting the Record!!");
                    }
                }


            }
            else
            {
                MessageBox.Show("Select Record");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" || txtSoyad.Text != "" || txtYeniSİfre2.Text != "" || txtYeniSifreT2.Text != "" || txtGorevID.Text != "")
            {
                if (txtYeniSifreT2.Text.Trim() == txtYeniSİfre2.Text.Trim())
                {
                    Employees2 p = new Employees2();
                    p.EmployeeName1 = txtAd.Text;
                    p.EmployeeSurname1 = txtSoyad.Text;
                    p.EmployeeUsername1 = txtKullanıcıAdı.Text;
                    p.EmployeePassword1 = txtYeniSİfre2.Text;
                    p.EmployeeDutyID1 = Convert.ToInt32(txtGorevID.Text);
                    bool sonuc = pbl.PersonelEkle(p);
                    if (sonuc)
                    {
                        MessageBox.Show("Registration Added Successfully");
                        LintReservationBL hbll = new LintReservationBL();
                        EmployeeActions phh = new EmployeeActions();
                        phh.EmployeeID = General.EmployeeID;
                        phh.Operation = "New Staff Created";
                        phh.Date = DateTime.Now;
                        hbll.PersonelHareketleriniKaydet(phh);

                        temizleme();
                    }
                }
                else
                {
                    MessageBox.Show("Passwords Are Not the Same");
                }
                Listele();

            }

        }
        void temizleme()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtKullanıcıAdı.Text = "";
            txtYeniSifreT2.Text = "";
            txtYeniSİfre2.Text = "";
            txtGorevID.Text = "";
            txtIDPersonel.Text = "";
            lvPersoneller.Items.Clear();
        }

        private void btnDeğiştir2_Click(object sender, EventArgs e)
        {
            btnYeni.Enabled = false;
            btnKaydet.Enabled = false;
            btnSil.Enabled = true; ;
            txtYeniSifreT2.ReadOnly = false;
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                if (txtAd.Text != "" || txtSoyad.Text != "" || txtYeniSİfre2.Text != "" || txtYeniSifreT2.Text != "" || txtGorevID.Text != "")
                {
                    if (txtYeniSifreT2.Text.Trim() == txtYeniSİfre2.Text.Trim())
                    {
                        Employees2 p = new Employees2();
                        p.EmployeeName1 = txtAd.Text;
                        p.EmployeeSurname1 = txtSoyad.Text;
                        p.EmployeeUsername1 = txtKullanıcıAdı.Text;
                        p.EmployeePassword1 = txtYeniSİfre2.Text;
                        p.EmployeeDutyID1 = Convert.ToInt32(txtGorevID.Text);
                        bool sonuc = pbl.PersonelGuncelle(p, Convert.ToInt32(txtIDPersonel.Text));
                        if (sonuc)
                        {
                            MessageBox.Show("The update has been completed successfully");
                            LintReservationBL habl = new LintReservationBL();
                            EmployeeActions peh = new EmployeeActions();
                            peh.EmployeeID = General.EmployeeID;
                            peh.Operation = "Updated Employee Information";
                            peh.Date = DateTime.Now;
                            habl.PersonelHareketleriniKaydet(peh);
                            temizleme();
                            
                            Listele();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords Are Not the Same");
                    }

                }

            }
            else
            {
                MessageBox.Show("You Need to Select Registration");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Trim() != "" || textBox6.Text.Trim() != "")
            {
                if (textBox5.Text == textBox6.Text)
                {
                    bool sonuc = pbl.PersonelSifreDegistir(Convert.ToInt32(General.EmployeeID), Convert.ToInt32(textBox5.Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Password Change Process Completed Successfully");
                        txtYeniSifre.Text = "";
                        txtYeniSifreTekrar.Text = "";
                        LintReservationBL hbl = new LintReservationBL();
                        EmployeeActions ph = new EmployeeActions();
                        ph.EmployeeID = General.EmployeeID;
                        ph.Operation = "Changed Password";
                        ph.Date = DateTime.Now;
                        hbl.PersonelHareketleriniKaydet(ph);
                    }

                }
                else
                {
                    MessageBox.Show("Passwords Are Not the Same");
                }

            }
            else
            {
                MessageBox.Show("Do not leave the password field blank");
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void lvPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                btnSil.Enabled = true;
                btnDeğiştir2.Enabled = true;
                txtYeniSİfre2.ReadOnly = false;
                txtYeniSifreT2.ReadOnly = false;
                txtIDPersonel.Text = lvPersoneller.SelectedItems[0].SubItems[0].Text;
                cboxGorevi.SelectedIndex = Convert.ToInt32(lvPersoneller.SelectedItems[0].SubItems[1].Text) - 1;
                txtAd.Text = lvPersoneller.SelectedItems[0].SubItems[3].Text;
                txtSoyad.Text = lvPersoneller.SelectedItems[0].SubItems[4].Text;
                txtKullanıcıAdı.Text = lvPersoneller.SelectedItems[0].SubItems[5].Text;
            }

        }
    }
}
