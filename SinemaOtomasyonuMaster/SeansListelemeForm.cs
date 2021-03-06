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
    public partial class SeansListelemeForm : Form
    {
        SinemaOtomasyonuDbContext db;

        public SeansListelemeForm(SinemaOtomasyonuDbContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void dtpSecilenTarih_ValueChanged(object sender, EventArgs e)
        {


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dgvSeanslariListele.Rows.Clear();

            DateTime tarih = DateTime.Now;
            string saat = tarih.ToString("t");

            foreach (var item in db.Seanslar)
            {
                if (dtpSecilenTarih.Text == item.Tarih)
                {
                    if (chckKaldir.Checked == true)
                    {
                        if (string.Compare(saat, item.SeansZamani, true) == -1)
                        {
                            dgvSeanslariListele.Rows.Add(item.FilmAdi, item.SalonAdi, item.Tarih, item.SeansZamani);
                        }
                    }
                    else if (chckKaldir.Checked == false)
                    {
                        dgvSeanslariListele.Rows.Add(item.FilmAdi, item.SalonAdi, item.Tarih, item.SeansZamani);
                    }
                }
            }

            if (dgvSeanslariListele.Rows.Count == 0)
            {
                MessageBox.Show("Seçili Tarihde Herangi Film Gösterimi Yok.");
                return;
            }
        }
    }
}
