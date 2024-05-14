using LintReservation.BLL;
using LintReservation.MODEL;
using System;
using System.Collections;
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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmTables frm = new frmTables();
            this.Close();
            frm.Show();
        }
        int tableID; int AdisyonID;
        private void frmSiparis_Load(object sender, EventArgs e)
        {
            lblMasaNo.Text = General.ButtonValue;
            TablesBL mbl = new TablesBL();

            tableID = mbl.TableGetByNumber(General.ButtonName);
            if (mbl.TableGetByState(tableID, 2) == true || mbl.TableGetByState(tableID, 4) == true)
            {
                BilllBL abl = new BilllBL();
                AdisyonID = abl.AdisyonBilgileriniGetir(tableID);
                OrderBL sbl = new OrderBL();
                List<Products> lst = sbl.SiparisGetirmece(AdisyonID);
                for (int i = 0; i < lst.Count; i++)
                {
                    lvSiparisler.Items.Add(lst[i].ProductName);
                    lvSiparisler.Items[i].SubItems.Add(lst[i].Amount.ToString());
                    lvSiparisler.Items[i].SubItems.Add(lst[i].ProductID.ToString());
                    lvSiparisler.Items[i].SubItems.Add(lst[i].Total.ToString());
                    lvSiparisler.Items[i].SubItems.Add(lst[i].ID.ToString());

                }
            }

            btn1.Click += new EventHandler(islem);
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);

        }
        void islem(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btn1":
                    txtAdet.Text += (1).ToString();
                    break;
                case "btn2":
                    txtAdet.Text += (2).ToString();
                    break;
                case "btn3":
                    txtAdet.Text += (3).ToString();
                    break;
                case "btn4":
                    txtAdet.Text += (4).ToString();
                    break;
                case "btn5":
                    txtAdet.Text += (5).ToString();
                    break;
                case "btn6":
                    txtAdet.Text += (6).ToString();
                    break;
                case "btn7":
                    txtAdet.Text += (7).ToString();
                    break;
                case "btn8":
                    txtAdet.Text += (8).ToString();
                    break;
                case "btn9":
                    txtAdet.Text += (9).ToString();
                    break;
                case "btn0":
                    txtAdet.Text += (0).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAdet.Clear();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            string btnName = " ";
            Button btn = (Button)sender;
            btnName = btn.Name;
            ProductCategoriesBL ubl = new ProductCategoriesBL();
            List<ProductCategories> lst = ubl.UruncesitleriGetrirmece(btnName);
            lvMenu.Items.Clear();
            for (int i = 0; i < lst.Count; i++)
            {
                lvMenu.Items.Add(lst[i].ProductName);
                lvMenu.Items[i].SubItems.Add(lst[i].Price.ToString());
                lvMenu.Items[i].SubItems.Add(lst[i].ID.ToString());
            }
        }
        int sayac = 0; int sayac2 = 0;
        private void lvMenu_DoubleClick(object sender, EventArgs e)
        {
            if (txtAdet.Text == "")
            {
                txtAdet.Text = "1";

            }
            if (lvMenu.Items.Count > 0)
            {
                sayac = lvSiparisler.Items.Count;
                lvSiparisler.Items.Add(lvMenu.SelectedItems[0].Text);
                lvSiparisler.Items[sayac].SubItems.Add(txtAdet.Text);
                lvSiparisler.Items[sayac].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvSiparisler.Items[sayac].SubItems.Add((Convert.ToDecimal(lvMenu.SelectedItems[0].SubItems[1].Text) * Convert.ToDecimal(txtAdet.Text)).ToString());
                lvSiparisler.Items[sayac].SubItems.Add("0");
                sayac2 = lvYeniEklenenler.Items.Count;
                lvSiparisler.Items[sayac].SubItems.Add(sayac2.ToString());
                lvYeniEklenenler.Items.Add(AdisyonID.ToString());
                lvYeniEklenenler.Items[sayac2].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvYeniEklenenler.Items[sayac2].SubItems.Add(txtAdet.Text);
                lvYeniEklenenler.Items[sayac2].SubItems.Add(tableID.ToString());
                lvYeniEklenenler.Items[sayac2].SubItems.Add(sayac2.ToString());

                sayac2++;
                txtAdet.Text = "";

            }
        }
        ArrayList silinenler = new ArrayList();
        private void btnSipariş_Click(object sender, EventArgs e)
        {

            TablesBL mbl = new TablesBL();
            BilllBL abl = new BilllBL();
            Bill ad = new Bill();
            Order order = new Order();
            OrderBL sbl = new OrderBL();
            frmTables frm = new frmTables();
            bool sonuc = false;
            if (mbl.TableGetByState(tableID, 1) == true)
            {
                ad.EmployeeId = 1;
                ad.TableId = tableID;
                ad.Date = DateTime.Now;
                sonuc = abl.YeniAdisyon(ad);
                mbl.TabloDurumunuDegistir(General.ButtonName, 2);
                if (lvSiparisler.Items.Count > 0)
                {
                    for (int i = 0; i < lvSiparisler.Items.Count; i++)
                    {
                        order.TableID = tableID;
                        order.ProductID = Convert.ToInt32(lvSiparisler.Items[i].SubItems[2].Text);
                        order.BillID = abl.AdisyonBilgileriniGetir(tableID);
                        order.Amount = Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text);
                        sbl.SiparisiKaydet(order);

                    }
                    this.Close();
                    frm.Show();

                }
            }

            else if (mbl.TableGetByState(tableID, 2) == true || mbl.TableGetByState(tableID, 4) == true)
            {
                if (lvYeniEklenenler.Items.Count > 0)
                {
                    for (int i = 0; i < lvYeniEklenenler.Items.Count; i++)
                    {
                        order.TableID = tableID;
                        order.ProductID = Convert.ToInt32(lvYeniEklenenler.Items[i].SubItems[1].Text);
                        order.BillID = abl.AdisyonBilgileriniGetir(tableID);
                        order.Amount = Convert.ToInt32(lvYeniEklenenler.Items[i].SubItems[2].Text);
                        sbl.SiparisiKaydet(order);

                    }
                    this.Close();
                    frm.Show();
                }
                if (silinenler.Count > 0)
                {
                    foreach (string item in silinenler)
                    {
                        sbl.SiparisiSil(Convert.ToInt32(item));
                    }
                }


            }
            else if (mbl.TableGetByState(tableID, 3) == true)
            {
                ad.EmployeeId = 1;
                ad.TableId = tableID;
                ad.Date = DateTime.Now;
                sonuc = abl.YeniAdisyon(ad);
                mbl.TabloDurumunuDegistir(General.ButtonName, 4);
                if (lvSiparisler.Items.Count > 0)
                {
                    for (int i = 0; i < lvSiparisler.Items.Count; i++)
                    {
                        order.TableID = tableID;
                        order.ProductID = Convert.ToInt32(lvSiparisler.Items[i].SubItems[2].Text);
                        order.BillID = abl.AdisyonBilgileriniGetir(tableID);
                        order.Amount = Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text);
                        sbl.SiparisiKaydet(order);

                    }
                    this.Close();
                    frm.Show();

                }

            }


        }

        private void lvSiparisler_DoubleClick(object sender, EventArgs e)
        {
            if (lvSiparisler.Items.Count > 0)
            {
                if (lvSiparisler.SelectedItems[0].SubItems[4].Text != "0")
                {
                    OrderBL sbl = new OrderBL();
                    sbl.SiparisiSil(Convert.ToInt32(lvSiparisler.SelectedItems[0].SubItems[4].Text));
                }
                else
                {
                    for (int i = 0; i < lvYeniEklenenler.Items.Count; i++)
                    {
                        if (lvYeniEklenenler.Items[i].SubItems[4].Text == lvSiparisler.SelectedItems[0].SubItems[5].Text)
                        {
                            lvYeniEklenenler.Items.RemoveAt(i);
                        }

                    }
                }
                lvSiparisler.Items.RemoveAt(lvSiparisler.SelectedItems[0].Index);

            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text == "")
            {
                txtAra.Text = "";
            }
            else
            {
                ProductCategoriesBL ubl = new ProductCategoriesBL();
                List<ProductCategories> lst = ubl.UruncesitleriAramaca(Convert.ToInt32(txtAra.Text));
                lvMenu.Items.Clear();
                for (int i = 0; i < lst.Count; i++)
                {
                    lvMenu.Items.Add(lst[i].ProductName);
                    lvMenu.Items[i].SubItems.Add(lst[i].Price.ToString());
                    lvMenu.Items[i].SubItems.Add(lst[i].ID.ToString());
                }
            }

        }

        private void btnÖdeme_Click(object sender, EventArgs e)
        {
            General.BillID = AdisyonID;
            frmBill frm = new frmBill();
            frm.Show();
            this.Close();
        }
    }
}
