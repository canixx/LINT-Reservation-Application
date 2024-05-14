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
    public partial class frmFirst : Form
    {
        LintReservationBL hbl = new LintReservationBL();
        public frmFirst()
        {
            InitializeComponent();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            cbKullanici.DisplayMember = "EmployeeNameandSurname";
            cbKullanici.ValueMember = "ID";
            cbKullanici.DataSource = hbl.PersonelBilgileriniGetir();

        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            General gnl = new General();

            bool result = hbl.PersonelGirisKontrol(txtSifre.Text, General.EmployeeID);

            if (result)
            {
                EmployeeActions ch = new EmployeeActions();
                ch.EmployeeID = General.EmployeeID;
                ch.Operation = "Login Made";
                ch.Date = DateTime.Now;
                hbl.PersonelHareketleriniKaydet(ch);
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Your Password is Incorrect", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employees p = (Employees)cbKullanici.SelectedItem;
            General.EmployeeID = p.EmployeeID1;
            General.DutyID = p.EmployeeDutyID1;
        }

        private void btnYeniKayıt_Click(object sender, EventArgs e)
        {
            frmAccount frm=new frmAccount();
            this.Hide();
            frm.Show();
            
        }
    }
}
