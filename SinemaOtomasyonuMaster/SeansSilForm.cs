using SinemaOtomasyonuMaster.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonuMaster
{
    public partial class SeansSilForm : Form
    {
        SinemaOtomasyonuDbContext db;
        public SeansSilForm(SinemaOtomasyonuDbContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void btnSeansListele_Click(object sender, EventArgs e)
        {
            SeanslariListele();
        }

        private void SeanslariListele()
        {
            dgvListele.Rows.Clear();

            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dtpSeansSilTarih.Value.ToString());
            string saat = yeni.ToString("t");

            if (yeni < bugun)
            {
                MessageBox.Show("Geriye dönük işlem yapılamaz!!!");
                dtpSeansSilTarih.Text = DateTime.Now.ToShortDateString();
                return;
            }
            else
            {
                foreach (var item in db.Seanslar)
                {
                    if (dtpSeansSilTarih.Text == item.Tarih)
                    {
                        if (string.Compare(saat, item.SeansZamani, true) == -1)
                        {
                            dgvListele.Rows.Add(item.SeansId, item.FilmAdi, item.Tarih, item.SeansZamani);
                        }
                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            int id = (int)dgvListele.SelectedRows[0].Cells[0].Value;
            var silinecekSeans = db.Seanslar.Where(x=>x.SeansId==id).FirstOrDefault();

            if (dgvListele.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show
                (
                "Seçili seans kaldırılacaktır. Seçili Seansdan Satış Yapıldıysa Bütün Bilgiler Silinecektir Onaylıyor musunuz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
                 );

                
                if (dr == DialogResult.Yes)
                {
                    db.Seanslar.Remove(silinecekSeans);
                    db.SaveChanges();
                }
              
                SeanslariListele();
            }
        }
    }
}
