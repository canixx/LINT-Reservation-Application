using LintReservation.BLL;
using LintReservation.MODEL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LintReservation.App
{
    public partial class frmTables : Form
    {
        TablesBL mbl = new TablesBL();
        public frmTables()
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

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            frmOrder frm = new frmOrder();
            int uzunluk = btn.Text.Length;
            General.ButtonValue = btn.Text.Substring(uzunluk - 6, 6);
            General.ButtonName = btn.Name;
            this.Close();
            frm.Show();

        }

        private void frmMasalar_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= mbl.MasaSayisiBul(); i++)
            {
                Button btn = new Button();
                btn.Name = "btnMasa" + i.ToString();
                btn.Text = "TABLE" + " " + i.ToString();
                btn.Width = 150;
                btn.Height = 90;
                btn.Font = new Font("Arial", 11, FontStyle.Bold);
                btn.ForeColor = Color.Honeydew;
                btn.FlatStyle = FlatStyle.Popup;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                pnl1.Controls.Add(btn);
                btn.Click += Btn_Click;
            }


            foreach (Control item in this.pnl1.Controls)
            {
                if (item is Button)
                {

                    for (int i = 1; i <= 10; i++)
                    {
                        if (item.Name == "btnMasa" + i.ToString())
                        {
                            if (mbl.DurumGetir(i) == 1)
                            {
                                item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.table_xxl);
                            }
                            else if (mbl.DurumGetir(i) == 2)
                            {
                                item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.MasalarDolu);
                            }
                            else if (mbl.DurumGetir(i) == 3)
                            {
                                item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.MasalarAçıkRezerve);
                            }
                            else if (mbl.DurumGetir(i) == 4)
                            {
                                item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.MasalarRezervasyon);
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("couldn't read");
                }

            }
        }


    }
}

