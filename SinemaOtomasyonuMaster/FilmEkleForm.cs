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
    public partial class FilmEkleForm : Form
    {
        SinemaOtomasyonuDbContext db;
        public FilmEkleForm(SinemaOtomasyonuDbContext db)
        {
            InitializeComponent();
            this.db = db;
            cboFilmTur.SelectedIndex = 0;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            opdResimAc.ShowDialog();
            pbResim.ImageLocation = opdResimAc.FileName; // Seçilen resmi picturebox a koydum
            txtResim.Text = opdResimAc.FileName; // Seçilen resmin dosya yolu ve ismi
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string filmAd = txtFilmAd.Text.Trim();
            string filmTur = cboFilmTur.SelectedItem.ToString();
            string yonetmen = txtYonetmen.Text.Trim();
            string sure = txtSure.Text.Trim();
            string yapimYili = txtYapimYili.Text.Trim();
            string tarih = dtpTarih.Text;
            string filmAciklama = txtFilmAciklama.Text.Trim();
            string filmResim = txtResim.Text.Trim();


            if (filmAd == "" || filmTur == "" || yonetmen == "" || sure == "" || yapimYili == "" || tarih == "" || filmAciklama == "" || filmResim == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            //foreach (var item in db.Filmler)
            //{
            //    if (filmAd==item.FilmAd||yonetmen==item.Yonetmen||filmTur==item.FilmTur)
            //    {
            //        MessageBox.Show("Bu film daha önce eklendi!!!");
            //        return;
            //    }
            //}

            db.Filmler.Add(new Film()
            {
                FilmAd = filmAd,
                FilmTur = filmTur,
                Yonetmen = yonetmen,
                FilmSüresi = sure,
                YapimYili = yapimYili,
                Tarih = tarih,
                FilmAciklama = filmAciklama,
                FilmResim = filmResim,
                FilmDurumu = true

            }) ;
            db.SaveChanges();
            FilimleriListele();
            IcerigiTemizle();

        }

        private void IcerigiTemizle()
        {
            txtFilmAd.Clear();
            txtFilmAciklama.Clear();
            txtYonetmen.Clear();
            txtSure.Clear();
            txtYapimYili.Clear();
            txtResim.Clear();
            cboFilmTur.SelectedIndex = 0;
            pbResim.Image = null;
        }

        private void FilimleriListele()
        {
            dgvFilimler.DataSource = db.Filmler.ToList();
            this.dgvFilimler.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void FilmEkleForm_Load(object sender, EventArgs e)
        {
            FilimleriListele();
        }

        Film secilen;
        private void dgvFilimler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            secilen = (Film)dgvFilimler.SelectedRows[0].DataBoundItem;

            txtFilmAd.Text = secilen.FilmAd;
            cboFilmTur.Text = secilen.FilmTur;
            txtYonetmen.Text = secilen.Yonetmen;
            txtSure.Text = secilen.FilmSüresi;
            txtYapimYili.Text = secilen.YapimYili;
            dtpTarih.Text = secilen.Tarih;
            txtFilmAciklama.Text = secilen.FilmAciklama;
            txtResim.Text = secilen.FilmResim;
            pbResim.ImageLocation = secilen.FilmResim;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {


            secilen.FilmAd = txtFilmAd.Text.Trim();
            secilen.FilmTur= cboFilmTur.SelectedItem.ToString();
            secilen.Yonetmen= txtYonetmen.Text.Trim();
            secilen.FilmSüresi= txtSure.Text.Trim();
            secilen.YapimYili= txtYapimYili.Text.Trim();
            secilen.Tarih= dtpTarih.Text;
            secilen.FilmAciklama= txtFilmAciklama.Text.Trim();
            secilen.FilmResim= txtResim.Text.Trim();

            db.SaveChanges();
            IcerigiTemizle();
            FilimleriListele();

        }

        private void btnFilmKaldir_Click(object sender, EventArgs e)
        {
            
            string filmAd = txtFilmAd.Text.Trim();
            string filmTur = cboFilmTur.SelectedItem.ToString();
            string yonetmen = txtYonetmen.Text.Trim();
            string sure = txtSure.Text.Trim();
            string yapimYili = txtYapimYili.Text.Trim();
            string tarih = dtpTarih.Text;
            string filmAciklama = txtFilmAciklama.Text.Trim();
            string filmResim = txtResim.Text.Trim();

            if (filmAd == "" || filmTur == "" || yonetmen == "" || sure == "" || yapimYili == "" || tarih == "" || filmAciklama == "" || filmResim == "")
            {
                MessageBox.Show("Lütfen Kaldıracağınız Filmi Seçiniz.");
                return;
            }

            secilen.FilmDurumu = false;
            db.SaveChanges();
            IcerigiTemizle();
            FilimleriListele();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            

            string filmAd = txtFilmAd.Text.Trim();
            string filmTur = cboFilmTur.SelectedItem.ToString();
            string yonetmen = txtYonetmen.Text.Trim();
            string sure = txtSure.Text.Trim();
            string yapimYili = txtYapimYili.Text.Trim();
            string tarih = dtpTarih.Text;
            string filmAciklama = txtFilmAciklama.Text.Trim();
            string filmResim = txtResim.Text.Trim();

            if (filmAd == "" || filmTur == "" || yonetmen == "" || sure == "" || yapimYili == "" || tarih == "" || filmAciklama == "" || filmResim == "")
            {
                MessageBox.Show("Lütfen Ekleyeceğiniz Filmi Seçiniz.");
                return;
            }

            secilen.FilmDurumu = true;
            db.SaveChanges();
            IcerigiTemizle();
            FilimleriListele();
            this.Close();
        }
    }
}
