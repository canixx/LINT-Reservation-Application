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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            frm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        OrderBL sbl = new OrderBL();
        private void frmFatura_Load(object sender, EventArgs e)
        {
            lblAdisyonID.Text = (General.BillID).ToString();
            List<Products> lst = sbl.SiparisGetirmece(General.BillID);
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            for (int i = 0; i < lst.Count; i++)
            {
                lvUrunler.Items.Add(lst[i].ProductName);
                lvUrunler.Items[i].SubItems.Add(lst[i].Amount.ToString());
                lvUrunler.Items[i].SubItems.Add(lst[i].ProductID.ToString());
                lvUrunler.Items[i].SubItems.Add(lst[i].Total.ToString());
                lvUrunler.Items[i].SubItems.Add(lst[i].ID.ToString());
            }

            if (lvUrunler.Items.Count > 0)
            {
                decimal toplam = 0;
                for (int i = 0; i < lvUrunler.Items.Count; i++)
                {
                    toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                }
                lblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                lblOdenecek.Text = string.Format("{0:0.000}", toplam);
                decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
                lblKDV.Text = string.Format("{0:0.000}", kdv);

            }
            //gboxtutar.Visible = true;
            textBox1.Clear();
        }


        private void chkİndirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkİndirim.Checked)
            {
                pnl1.Visible = true;
                textBox1.Clear();
                LintReservationBL habl = new LintReservationBL();
                EmployeeActions peh = new EmployeeActions();
                peh.EmployeeID = General.EmployeeID;
                peh.Operation = "Discounted";
                peh.Date = DateTime.Now;
                habl.PersonelHareketleriniKaydet(peh);
            }
            else
            {
                pnl1.Visible = false;
                textBox1.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(textBox1.Text) < Convert.ToDecimal(lblToplamTutar.Text))
                {
                    try
                    {
                        lblIndirim.Text = string.Format("{0:0.000}", Convert.ToDecimal(textBox1.Text));

                    }
                    catch (Exception)
                    {
                        lblIndirim.Text = string.Format("{0:0.000}", 0);
                    }
                }
                else
                {
                    MessageBox.Show("Discount Amount cannot be more than the total amount");
                }

            }
            catch (Exception)
            {
                lblIndirim.Text = string.Format("{0:0.000}", 0);
            }
        }

        private void lblIndirim_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblIndirim.Text) > 0)
            {
                decimal odenecek = 0;
                lblOdenecek.Text = lblToplamTutar.Text;
                odenecek = Convert.ToDecimal(lblOdenecek.Text) - Convert.ToDecimal(lblIndirim.Text);
                lblOdenecek.Text = string.Format("{0:0.000}", odenecek);

            }
        }
        TablesBL mbl = new TablesBL();
        ReservationBL rezerve = new ReservationBL();
        Paying ob = new Paying();
        PayBL obl = new PayBL();
        BilllBL abl = new BilllBL();
        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            int masaid = mbl.TableGetByNumber(General.ButtonName);
            int musteriID = 0;
            if (mbl.TableGetByState(masaid, 4) == true)
            {
                musteriID = rezerve.MusteriIDBulRezerve(masaid);
            }
            else
            {
                musteriID = 1;
            }
            int odemeturID = 0;
            if (rbNakit.Checked == false && rbKredi.Checked == false)
            {
                MessageBox.Show("Select Payment Type");

            }
            else
            {
                if (rbNakit.Checked)
                {
                    odemeturID = 1;
                }

                if (rbKredi.Checked)
                {
                    odemeturID = 2;
                }
                ob.BillID = Convert.ToInt32(lblAdisyonID.Text);
                ob.PayID = odemeturID;
                ob.CustomerID = musteriID;
                ob.Subtotal = Convert.ToDecimal(lblOdenecek.Text);
                ob.Kdvamount = Convert.ToDecimal(lblKDV.Text);
                ob.Total = Convert.ToDecimal(lblToplamTutar.Text);
                ob.Discount = Convert.ToDecimal(lblIndirim.Text);
                bool result = obl.FaturaKapama(ob);
                if (result == true)
                {
                    mbl.TabloDurumunuDegistir(Convert.ToString(masaid), 1);
                    rezerve.RezervasyonKapat(Convert.ToInt32(lblAdisyonID.Text));
                    abl.AdisyonKapama(Convert.ToInt32(lblAdisyonID.Text), 0);
                    MessageBox.Show("Order Closed Successfully");
                    LintReservationBL habl = new LintReservationBL();
                    EmployeeActions peh = new EmployeeActions();
                    peh.EmployeeID = General.EmployeeID;
                    peh.Operation = "Closed order";
                    peh.Date = DateTime.Now;
                    habl.PersonelHareketleriniKaydet(peh);
                    this.Close();
                    frmTables frm = new frmTables();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("There was a problem closing the order!!");
                }
            }

        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        Font Baslik = new Font("Verdana", 15, FontStyle.Bold);
        Font altBaslik = new Font("Verdana", 12, FontStyle.Regular);
        Font icerik = new Font("Verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("LINT RESTAURANT", Baslik, sb, 300, 100, st);
            e.Graphics.DrawString("------------------------------", altBaslik, sb, 300, 120, st);
            e.Graphics.DrawString("Name of the product                         Amount      Price", altBaslik, sb, 150, 250, st);
            e.Graphics.DrawString("----------------------------------------------------------------", altBaslik, sb, 150, 280, st);
            for (int i = 0; i < lvUrunler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[0].Text, icerik, sb, 150, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[1].Text, icerik, sb, 500, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[3].Text, icerik, sb, 570, 300 + i * 30, st);
            }
            e.Graphics.DrawString("----------------------------------------------------------------", altBaslik, sb, 150, 300 + 30 * lvUrunler.Items.Count, st);
            e.Graphics.DrawString("Discount Amount   :-----------------" + lblIndirim.Text + "TL", altBaslik, sb, 150, 300 + 30 * (lvUrunler.Items.Count + 1), st);
            e.Graphics.DrawString("KDV Amount       :-----------------" + lblKDV.Text + "TL", altBaslik, sb, 150, 300 + 30 * (lvUrunler.Items.Count + 2), st);
            e.Graphics.DrawString("Total amount     :-----------------" + lblToplamTutar.Text + "TL", altBaslik, sb, 150, 300 + 30 * (lvUrunler.Items.Count + 3), st);
            e.Graphics.DrawString("Amount You Paid :-----------------" + lblOdenecek.Text + "TL", altBaslik, sb, 150, 300 + 30 * (lvUrunler.Items.Count + 4), st);
        }
    }
}
