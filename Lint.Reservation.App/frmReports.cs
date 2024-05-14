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
using System.Windows.Forms.DataVisualization.Charting;

namespace LintReservation.App
{
    public partial class frmReports : Form
    {
        public frmReports()
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
            frm.Show();
            this.Close();
        }
        ProductsBL ubl = new ProductsBL();
        private void btnAnaYemek1_Click(object sender, EventArgs e)
        {
            chRapor.Series["Sales"].Points.Clear();
            istatistikgetir("Statistics of Main Dishes", 1, Color.Red);
        }
        private void istatistikgetir(string gbName, int KatID, Color renk)
        {
            chRapor.Palette = ChartColorPalette.None;
            chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chRapor.Series[0].Color = renk;
            string baslangic = dtBaşlangıç.Value.ToShortDateString();
            string bitis = dtBitiş.Value.ToShortDateString();
            List<Products> lst = ubl.UrunListeleIstatistiklereGorewUrunID(baslangic, bitis, KatID);
            for (int i = 0; i < lst.Count; i++)
            {
                listView1.Items.Add(lst[i].ProductName);
                listView1.Items[i].SubItems.Add(lst[i].Amount.ToString());

            }
            gboxİstatistik.Text = gbName;
            gboxİstatistik.ForeColor = Color.White;
            if (listView1.Items.Count > 0)
            {
                chRapor.Series["Sales"].Points.Clear();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    chRapor.Series["Sales"].Points.AddXY(listView1.Items[i].SubItems[0].Text, listView1.Items[i].SubItems[1].Text);
                }
            }

        }

        private void btnAraSicaklar2_Click(object sender, EventArgs e)
        {
            istatistikgetir("Statistics of Intermediate Temperatures", 2, Color.Aqua);
        }

        private void btnSalatalar3_Click(object sender, EventArgs e)
        {
            istatistikgetir("Statistics of Salads", 3, Color.Green);
        }

        private void btnMezeler4_Click(object sender, EventArgs e)
        {
            istatistikgetir("Statistics of Appetizers", 4, Color.MediumAquamarine);
        }

        private void btnİçkiler5_Click(object sender, EventArgs e)
        {
            istatistikgetir("Statistics of Drinks", 5, Color.Gold);
        }

        private void btnAperatifler6_Click(object sender, EventArgs e)
        {
            istatistikgetir("Statistics of Snacks", 6, Color.MediumOrchid);
        }

        private void btnTümÜrünler_Click(object sender, EventArgs e)
        {
            chRapor.Palette = ChartColorPalette.None;
            chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chRapor.Series[0].Color = Color.LightBlue;
            string baslangic = dtBaşlangıç.Value.ToShortDateString();
            string bitis = dtBitiş.Value.ToShortDateString();
            List<Products> lst = ubl.UrunListeleIstatistiklereGore(baslangic, bitis);
            for (int i = 0; i < lst.Count; i++)
            {
                listView1.Items.Add(lst[i].ProductName);
                listView1.Items[i].SubItems.Add(lst[i].Amount.ToString());

            }
            gboxİstatistik.Text = "ALL PRODUCTS";
            gboxİstatistik.ForeColor = Color.White;
            if (listView1.Items.Count > 0)
            {
                chRapor.Series["Sales"].Points.Clear();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    chRapor.Series["Sales"].Points.AddXY(listView1.Items[i].SubItems[0].Text, listView1.Items[i].SubItems[1].Text);
                }
            }

        }
    }
}
