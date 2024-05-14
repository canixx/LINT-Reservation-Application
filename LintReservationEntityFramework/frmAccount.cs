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
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmGiris frm = new frmGiris();
            frm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
       
        private void btnkayit_Click(object sender, EventArgs e)
        {
            if (cmbGorev.SelectedIndex == 0)
            {
                MessageBox.Show("Görev Seçiniz!");
                return;
            }
            using (HayyamDB hb = new HayyamDB())
            {
                    hb.tbl_employees.Add(new tbl_employees { DUTY_ID = Convert.ToInt32(cmbGorev.SelectedValue), NAME = txtAd.Text, SURNAME = txtSoyad.Text, USERNAME = txtKullanici.Text, PASSWORD = txtParola.Text });
                     
                    hb.SaveChanges();
                    MessageBox.Show("Ekleme İşlemi Başarılı");
                    temizle();               
            }
            
        }
        void temizle() 
        {
            txtAd.Text = "";
            txtKullanici.Text = "";
            txtParola.Text = "";
            txtSoyad.Text = "";
            cmbGorev.SelectedIndex = 0;
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            HayyamDB hdb = new HayyamDB();
            List<tbl_employee_dutys> lst = new List<tbl_employee_dutys>();            
            using (hdb)
            {
                lst = hdb.tbl_employee_dutys.ToList();
                foreach (var item in lst)
                {
                    cmbGorev.Items.Add(item.ID);
                }
                lst.Insert(0, new tbl_employee_dutys { DUTY = "Please Select Duty" });

            }
            cmbGorev.DataSource = lst;
            cmbGorev.ValueMember = "ID";
            cmbGorev.DisplayMember = "DUTY";
        }
    }
}
