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
    public partial class frmCustomers : Form
    {
        DataTable dt;
        public frmCustomers()
        {
            InitializeComponent();
            DataTable.AutoGenerateColumns = false;
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

        private void btnYeniMüsteri_Click(object sender, EventArgs e)
        {
            CustomersBL mbl = new CustomersBL();
            LintReservationBL habl = new LintReservationBL();
            EmployeeActions peh = new EmployeeActions();
            foreach (DataRow item in dt.Rows)
            {
                Customers m = new Customers();
                if (item.RowState != DataRowState.Deleted)
                {
                    m.CustomerName = item["NAME"].ToString();
                    m.CustomerSurname = item["SURNAME"].ToString();
                    m.Phone = item["PHONE"].ToString();
                    m.Address = item["ADDRESS"].ToString();
                    m.Email = item["EMAIL"].ToString();
                }
                switch (item.RowState)
                {
                    case DataRowState.Added:
                        mbl.MusteriEkle(m);
                        MessageBox.Show("Customer Addition Successful");
                        peh.EmployeeID = General.EmployeeID;
                        peh.Operation = "Customer Added";
                        peh.Date = DateTime.Now;
                        habl.PersonelHareketleriniKaydet(peh);
                        break;
                    case DataRowState.Deleted:
                        mbl.MusteriSil(Convert.ToInt32(item[0, DataRowVersion.Original]));
                        MessageBox.Show("Customer Deletion Successful");
                        peh.EmployeeID = General.EmployeeID;
                        peh.Operation = "Customer Deleted";
                        peh.Date = DateTime.Now;
                        habl.PersonelHareketleriniKaydet(peh);
                        break;
                    case DataRowState.Modified:
                        m.CustomerID = (int)item["ID"];
                        mbl.MusteriGuncelle(m);
                        MessageBox.Show("Customer Update Job Successful");
                        peh.EmployeeID = General.EmployeeID;
                        peh.Operation = "Updated Customer Information";
                        peh.Date = DateTime.Now;
                        habl.PersonelHareketleriniKaydet(peh);
                        break;
                    default:
                        break;
                }

            }


        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            CustomersBL mbl = new CustomersBL();
            dt = mbl.MusteriListele();
            DataTable.DataSource = dt;

        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {

        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReservations frm = new frmReservations();
            this.Close();
            frm.Show();
        }
    }
}
