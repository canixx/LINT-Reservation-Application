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
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }
        LintReservationBL hbl= new LintReservationBL();
        EmployeeBL pbl= new EmployeeBL();

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmFirst frm = new frmFirst();
            this.Close();
            frm.Show();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            cboxDuty.DataSource = hbl.DutyList();
            cboxDuty.DisplayMember = "DUTY";
            cboxDuty.ValueMember = "ID";
        }
        void cleanup() 
        {
            txtName.Text = "";
            txtPass.Text = "";
            txtSurname.Text = "";
            txtUsername.Text = "";
            cboxDuty.SelectedIndex = 0;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if(cboxDuty.SelectedIndex == 0)
            {
                MessageBox.Show("Select Duty!");
                return;

            }
            try
            {
                if (txtName.Text!="" && txtPass.Text!="" && txtSurname.Text!="" && txtUsername.Text!="")
                {
                    Employees2 p = new Employees2();
                    p.EmployeeName1 = txtName.Text;
                    p.EmployeeSurname1 = txtSurname.Text;
                    p.EmployeeDutyID1 = Convert.ToInt32(cboxDuty.SelectedValue);
                    p.EmployeeUsername1 = txtUsername.Text;
                    p.EmployeePassword1 = txtPass.Text;
                    pbl.PersonelEkle(p);
                    MessageBox.Show("User creation successful");
                    cleanup();

                }
                else
                {
                    MessageBox.Show("Please Fill all the blanks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Another user with the same Username is registered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cleanup();
            }

        }
    }
}
