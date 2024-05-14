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
    public partial class frmKitchen : Form
    {
        public frmKitchen()
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

        private void button1_Click(object sender, EventArgs e)
        {
            lblUrunArama.Visible = true;
            txtUrunArama.Visible = true;
            pnlEklemeİslemleri.Visible = false;
        }
        ProductsBL ubl = new ProductsBL();
        private void frmMutfak_Load(object sender, EventArgs e)
        {
            cboxKategori.DisplayMember = "AD";
            cboxKategori.ValueMember = "ID";
            cboxKategori.DataSource = ubl.UrunCesitleriniGetir();
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lblUrunArama.Visible = false;
            txtUrunArama.Visible = false;
            lvUrunListe.Visible = false;
            pnlEklemeİslemleri.Visible = true;
            Products urun = new Products();
            urun.CategoryID = Convert.ToInt32(txtKategoriID.Text);
            urun.ProductName = txtAd.Text;
            urun.Price = Convert.ToInt32(txtFiyat.Text);
            bool sonuc = Convert.ToBoolean(ubl.UrunEkle(urun));
            if (sonuc)
            {
                MessageBox.Show("Product Addition Successful");
                LintReservationBL habl = new LintReservationBL();
                EmployeeActions peh = new EmployeeActions();
                peh.EmployeeID = General.EmployeeID;
                peh.Operation = "Product Added";
                peh.Date = DateTime.Now;
                habl.PersonelHareketleriniKaydet(peh);
                temizle();
                Listele();
                lvUrunListe.Visible = true;
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (lvUrunListe.SelectedItems.Count > 0)
            {
                Products urun = new Products();
                urun.ID = Convert.ToInt32(lvUrunListe.SelectedItems[0].SubItems[0].Text);
                urun.CategoryID = Convert.ToInt32(txtKategoriID.Text);
                urun.ProductName = txtAd.Text;
                urun.Price = Convert.ToInt32(txtFiyat.Text);
                bool sonuc = ubl.UrunGüncelle(urun);
                if (sonuc)
                {
                    MessageBox.Show("Product Update Process Successful");
                    LintReservationBL habl = new LintReservationBL();
                    EmployeeActions peh = new EmployeeActions();
                    peh.EmployeeID = General.EmployeeID;
                    peh.Operation = "Updated Product Information";
                    peh.Date = DateTime.Now;
                    habl.PersonelHareketleriniKaydet(peh);
                    btnDegistir.Visible = false;
                    btnSil.Visible = false;
                    btnEkle.Visible = true;
                    button1.Visible= true;
                    lblUrunArama.Visible = false;
                    txtUrunArama.Visible = false;
                    txtUrunArama.Text = "";
                    temizle();
                    Listele();

                }

            }
        }
        void temizle()
        {
            txtAd.Text = "";
            txtFiyat.Text = "";
            lvUrunListe.Items.Clear();
        }

        private void cboxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKategoriID.Text = ubl.txtIDyazdırma(cboxKategori.Text).ToString();
        }

        private void lvUrunListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUrunListe.SelectedItems.Count > 0)
            {             
                               
                btnDegistir.Visible = true;
                btnSil.Visible = true;
                btnEkle.Visible = false;
                button1.Visible = false;
                pnlEklemeİslemleri.Visible = true;
                txtKategoriID.Text = lvUrunListe.SelectedItems[0].SubItems[1].Text;
                cboxKategori.SelectedIndex = Convert.ToInt32(lvUrunListe.SelectedItems[0].SubItems[1].Text) - 1;
                txtAd.Text = lvUrunListe.SelectedItems[0].SubItems[3].Text;
                txtFiyat.Text = lvUrunListe.SelectedItems[0].SubItems[4].Text;
               
            }
        }
        void Listele()
        {
            List<Products> lst = ubl.UrunleriListele();
            for (int i = 0; i < lst.Count; i++)
            {
                lvUrunListe.Items.Add((lst[i].ID).ToString());
                lvUrunListe.Items[i].SubItems.Add(lst[i].CategoryID.ToString());
                lvUrunListe.Items[i].SubItems.Add(lst[i].CategoryName.ToString());
                lvUrunListe.Items[i].SubItems.Add(lst[i].ProductName.ToString());
                lvUrunListe.Items[i].SubItems.Add(lst[i].Price.ToString());
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvUrunListe.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ubl.UrunSilmekİcinGerekli(Convert.ToInt32(lvUrunListe.SelectedItems[0].Text));
                    bool sonuc = ubl.UrunSil(Convert.ToInt32(lvUrunListe.SelectedItems[0].Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Product Deletion Completed Successfully");
                        LintReservationBL habl = new LintReservationBL();
                        EmployeeActions peh = new EmployeeActions();
                        peh.EmployeeID = General.EmployeeID;
                        peh.Operation = "A Product Deleted!";
                        peh.Date = DateTime.Now;
                        habl.PersonelHareketleriniKaydet(peh);
                        btnDegistir.Visible = false;
                        btnSil.Visible = false;
                        btnEkle.Visible = true;
                        button1.Visible = true;
                        lblUrunArama.Visible = false;
                        txtUrunArama.Visible = false;
                        txtUrunArama.Text = "";
                        temizle();
                        Listele();

                    }
                    else
                    {
                        MessageBox.Show("An Error Occurred While Deleting the Product");
                    }

                }

            }
            else
            {
                MessageBox.Show("Select Product");
            }
        }

        private void txtUrunArama_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtUrunArama_TextChanged(object sender, EventArgs e)
        {
            List<Products> lst = ubl.UrunleriListeleWUrunAdi(txtUrunArama.Text);
            temizle();

            for (int i = 0; i < lst.Count; i++)
            {
                lvUrunListe.Items.Add((lst[i].ID).ToString());
                lvUrunListe.Items[i].SubItems.Add(lst[i].CategoryID.ToString());
                lvUrunListe.Items[i].SubItems.Add(lst[i].CategoryName.ToString());
                lvUrunListe.Items[i].SubItems.Add(lst[i].ProductName.ToString());
                lvUrunListe.Items[i].SubItems.Add(lst[i].Price.ToString());

            }
        }
    }
}
