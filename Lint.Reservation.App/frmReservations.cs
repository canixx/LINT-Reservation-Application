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
    public partial class frmReservations : Form
    {
        public frmReservations()
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

        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            TablesBL mbl = new TablesBL();
            cboxMasaSec.DisplayMember = "Table info";
            cboxMasaSec.ValueMember = "ID";
            cboxMasaSec.DataSource = mbl.MasalarıGetir();
            Listele();
            txtMasaSec.Text = "";
            dtTarih.MinDate = DateTime.Today;
            dtTarih.Format = DateTimePickerFormat.Time;
        }

        private void btnYeniMüsteri_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers();
            this.Close();
            frm.Show();
        }
        Reservations rez = new Reservations();
        private void btnRezervasyonAc_Click(object sender, EventArgs e)
        {
            ReservationBL rbl = new ReservationBL();
            if (lvMusteriler.SelectedItems.Count > 0)
            {
                bool sonuc = rbl.RezervasyonAcikMiKontrol(Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text));
                if (!sonuc)
                {
                    if (txtTarih.Text != "")
                    {
                        if (txtKisiSayisi.Text != "")
                        {
                            TablesBL mbl = new TablesBL();
                            if (mbl.TableGetByState(Convert.ToInt32(txtMasaID.Text), 1))
                            {
                                BilllBL abl = new BilllBL();
                                Bill a = new Bill();
                                a.Date = Convert.ToDateTime(txtTarih.Text);
                                a.TableId = Convert.ToInt32(txtMasaID.Text);
                                a.EmployeeId = General.EmployeeID;
                                rez.CustomerID = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
                                rez.TableID = Convert.ToInt32(txtMasaID.Text);
                                rez.Date = Convert.ToDateTime(txtTarih.Text);
                                rez.ClientCount = Convert.ToInt32(txtKisiSayisi.Text);
                                rez.Description = txtAcıklama.Text;
                                abl.RezervasyonAdisyonAcma(a);
                                rez.BillID = abl.AdisyonBilgileriniGetir(Convert.ToInt32(txtMasaID.Text));
                                sonuc = rbl.RezervasyonAc(rez);
                                mbl.TabloDurumunuDegistir(txtMasaID.Text, 3);
                                if (sonuc)
                                {
                                    MessageBox.Show("Reservation has been opened successfully");
                                    LintReservationBL habl = new LintReservationBL();
                                    EmployeeActions peh = new EmployeeActions();
                                    peh.EmployeeID = General.EmployeeID;
                                    peh.Operation = "New Reservation Created";
                                    peh.Date = DateTime.Now;
                                    habl.PersonelHareketleriniKaydet(peh);
                                    cleanup();
                                }
                                else
                                {
                                    MessageBox.Show("ERROR When Opening a Reservation!!!");
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter Number of People");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Do not leave the date section blank");
                    }
                }
            }
        }
        void cleanup() 
        {
            txtTarih.Text = "";
            txtMasaSec.Text = "";
            txtMasaID.Text = "";
            txtKisiSayisi.Text = "";
            txtAcıklama.Text = "";
            cboxKisiSayisi.SelectedIndex = 0;
            cboxMasaSec.SelectedIndex = 0;            
            
        }

        private void dtTarih_MouseEnter(object sender, EventArgs e)
        {
            dtTarih.Width = 150;
        }

        private void dtTarih_Enter(object sender, EventArgs e)
        {
            dtTarih.Width = 150;
        }

        private void dtTarih_MouseLeave(object sender, EventArgs e)
        {
            dtTarih.Width = 23;
        }

        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtTarih.Value.ToString();
        }

        private void cboxKisiSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKisiSayisi.Text = cboxKisiSayisi.SelectedItem.ToString();
        }

        private void cboxMasaSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxKisiSayisi.Enabled = true;
            txtMasaSec.Text = cboxMasaSec.SelectedItem.ToString();
            string ad = "";
            int kapasite = 0;
            ad = cboxMasaSec.SelectedItem.ToString();
            string[] _Split = ad.Split(':');
            txtMasaID.Text = _Split[1];
            kapasite = Convert.ToInt32(_Split[3]);
            cboxKisiSayisi.Items.Clear();
            for (int i = 0; i < kapasite; i++)
            {
                cboxKisiSayisi.Items.Add(i + 1);
            }

        }

        private void cboxMasaSec_MouseEnter(object sender, EventArgs e)
        {
            cboxMasaSec.Width = 200;

        }

        private void cboxMasaSec_MouseLeave(object sender, EventArgs e)
        {
            cboxMasaSec.Width = 23;
        }

        private void cboxKisiSayisi_MouseLeave(object sender, EventArgs e)
        {
            cboxKisiSayisi.Width = 23;
        }

        private void cboxKisiSayisi_MouseEnter(object sender, EventArgs e)
        {
            cboxKisiSayisi.Width = 100;
        }
        void Listele()
        {
            CustomersBL mbl = new CustomersBL();
            List<Customers> lst = mbl.MüsterileriListelemece();
            for (int i = 0; i < lst.Count; i++)
            {
                lvMusteriler.Items.Add((lst[i].CustomerID.ToString()));
                lvMusteriler.Items[i].SubItems.Add(lst[i].CustomerName.ToString());
                lvMusteriler.Items[i].SubItems.Add(lst[i].CustomerSurname.ToString());
                lvMusteriler.Items[i].SubItems.Add(lst[i].Phone.ToString());
                lvMusteriler.Items[i].SubItems.Add(lst[i].Address.ToString());
                lvMusteriler.Items[i].SubItems.Add(lst[i].Email.ToString());

            }
        }
    }
}
