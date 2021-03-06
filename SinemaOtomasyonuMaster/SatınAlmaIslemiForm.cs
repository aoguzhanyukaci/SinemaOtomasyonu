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
    public partial class SatınAlmaIslemiForm : Form
    {
        SinemaOtomasyonuDbContext db;
        string film;
        string secilen;
        string secilenSeans;
        string secilenTarih;
        string secilenSalon;
        ListViewItem sec;

        public SatınAlmaIslemiForm(ListViewItem sec, string film, string secilen, string secilenSeans, string secilenTarih, string secilenSalon, SinemaOtomasyonuDbContext db)
        {
            this.film = film;
            this.secilen = secilen;
            this.secilenSeans = secilenSeans;
            this.secilenTarih = secilenTarih;
            this.secilenSalon = secilenSalon;
            this.sec = sec;
            this.db = db;
            InitializeComponent();
            txtSecilenFilm.Text = film;
            txtSecilenKoltuk.Text = secilen;
            txtSecilenTarih.Text = secilenTarih;
            txtSecilenSeans.Text = secilenSeans;
            txtSecilenSalon.Text = secilenSalon;
            cboBiletFiyati.SelectedIndex = 0;
            cboCinsiyet.SelectedIndex = 0;
            cboOdemeTuru.SelectedIndex = 0;
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            string filmAdi = txtSecilenFilm.Text;
            string filmTarihi = txtSecilenTarih.Text;
            string secilenSalon = txtSecilenSalon.Text;
            string secilenSeans = txtSecilenSeans.Text;
            string secilenKoltuk = txtSecilenKoltuk.Text;
            string biletTarihi = dtpBiletTarihi.Text;
            string odemeTuru = cboOdemeTuru.Text;
            string cinsiyet = cboCinsiyet.Text;
            string ucretNormal = "";
            string ucretOgrenci = "";
            int odemeDurumu = 0;
            int cinsiyetDurumu = 0;

            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dtpBiletTarihi.Value.ToString());


            if (yeni < bugun)
            {
                MessageBox.Show("Geriye Dönük Tarihli İşlem Yapılamaz!!!");
                dtpBiletTarihi.Text = DateTime.Now.ToShortDateString();
                return;
            }
            else if (cinsiyet == "Seçiniz")
            {
                MessageBox.Show("Lütfen Cinsiyet Alanını Seçiniz.");
                return;
            }
            else if (cboOdemeTuru.Text == "Seçiniz")
            {
                MessageBox.Show("Lütfen Ödeme Türü Alanını Seçiniz.");
                return;
            }
            else if (cboBiletFiyati.Text == "Seçiniz")
            {
                MessageBox.Show("Lütfen Bilet Fiyatı Alanını Seçiniz.");
                return;
            }


            if (cboBiletFiyati.Text == "Tam 20 ₺")
            {
                ucretNormal = 20.ToString("c2");
            }
            else if (cboBiletFiyati.Text == "Öğrenci 15 ₺")
            {
                ucretOgrenci = 15.ToString("c2");
            }

            if (cboCinsiyet.Text == "Bay")
            {
                cinsiyetDurumu = 1;
                sec.ImageKey = "Bay";
            }
            else if (cboCinsiyet.Text == "Bayan")
            {
                cinsiyetDurumu = 2;
                sec.ImageKey = "Bayan";
            }


            if (cboOdemeTuru.Text == "Nakit")
            {
                odemeDurumu = 1;
            }
            else if (cboOdemeTuru.Text == "Kredi Kartı")
            {
                odemeDurumu = 2;
            }



            db.Satislar.Add(new Satis()
            {
                FilmAdi = filmAdi,
                Tarih = biletTarihi,
                SalonAdi = secilenSalon,
                FilmSeansi = secilenSeans,
                KoltukNo = secilenKoltuk,
                Tarih2 = filmTarihi,
                Cinsiyet = cinsiyet,
                UcretNormal = ucretNormal,
                UcretOgrenci = ucretOgrenci,
                OdemeTuru = odemeTuru,
                OdemeDurum = odemeDurumu,
                CinsiyetDurum = cinsiyetDurumu

            });
            db.SaveChanges();
            DialogResult = DialogResult.OK;

        }



        private void cboBiletFiyati_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBiletFiyati.Text == "Tam 20 ₺")
            {
                lblTutar.Text = 20.ToString("c2");
            }
            else if (cboBiletFiyati.Text == "Öğrenci 15 ₺")
            {
                lblTutar.Text = 15.ToString("c2");
            }
        }

        private void SatınAlmaIslemiForm_Load(object sender, EventArgs e)
        {
            BlgiVer();
        }

        private void BlgiVer()
        {
            foreach (var item in db.Satislar)
            {
                if (film == item.FilmAdi)
                {
                    if (secilenTarih == item.Tarih)
                    {
                        if (secilenSalon == item.SalonAdi)
                        {
                            if (secilen == item.KoltukNo)
                            {
                                cboCinsiyet.Text = item.Cinsiyet;
                                cboOdemeTuru.Text = item.OdemeTuru;
                                dtpBiletTarihi.Text = secilenTarih;

                                if (item.UcretNormal == "")
                                {
                                    cboBiletFiyati.Text = item.UcretOgrenci;
                                    lblTutar.Text = item.UcretOgrenci;
                                    btnOdemeAl.Enabled = false;
                                }
                                else if (item.UcretOgrenci == "")
                                {
                                    cboBiletFiyati.Text = item.UcretNormal;
                                    lblTutar.Text = item.UcretNormal;
                                    btnOdemeAl.Enabled = false;
                                }
                            }
                        }
                    }
                }

            }
        }

        private void btnDuzenlemeYap_Click(object sender, EventArgs e)
        {
            int secilenId = 0;

            if (cboCinsiyet.Text == "Seçiniz")
            {
                MessageBox.Show("Herhangi Bir Kayıt Olmadığı İçin İşlem Yapılamaz.");
                return;
            }
            else if (cboOdemeTuru.Text == "Seçiniz")
            {
                MessageBox.Show("Herhangi Bir Kayıt Olmadığı İçin İşlem Yapılamaz.");
                return;
            }
            else if (cboBiletFiyati.Text == "Seçiniz")
            {
                MessageBox.Show("Herhangi Bir Kayıt Olmadığı İçin İşlem Yapılamaz.");
                return;
            }

            foreach (var item in db.Satislar)
            {
                if (film == item.FilmAdi)
                {
                    if (secilenTarih == item.Tarih)
                    {
                        if (secilenSeans == item.FilmSeansi)
                        {
                            if (item.KoltukNo == secilen)
                            {
                                secilenId = item.SatisId;
                            }
                        }
                    }
                }

            }


            var duzenle = db.Satislar.Find(secilenId);

            //duzenle.Tarih = dtpBiletTarihi.Text;
            duzenle.Cinsiyet = cboCinsiyet.Text;
            duzenle.OdemeTuru = cboOdemeTuru.Text;

            if (cboBiletFiyati.Text == "Tam 20 ₺")
            {
                duzenle.UcretNormal = 20.ToString("c2");
                duzenle.UcretOgrenci = "";
            }
            else if (cboBiletFiyati.Text == "Öğrenci 15 ₺")
            {
                duzenle.UcretOgrenci = 15.ToString("c2");
                duzenle.UcretNormal = "";
            }

            if (cboCinsiyet.Text == "Bay")
            {
                duzenle.CinsiyetDurum = 1;
                sec.ImageKey = "Bay";
            }
            else if (cboCinsiyet.Text == "Bayan")
            {
                duzenle.CinsiyetDurum = 2;
                sec.ImageKey = "Bayan";
            }
            else if (cboCinsiyet.Text == "Seçiniz")
            {
                duzenle.CinsiyetDurum = 0;
                sec.ImageKey = "Bos";
            }

            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnBiletIptal_Click(object sender, EventArgs e)
        {
            int secilenId = 0;

            if (cboCinsiyet.Text == "Seçiniz")
            {
                MessageBox.Show("Kayıtlı Bilet Olmadığı İçin İptal Edilemez.");
                return;
            }
            else if (cboOdemeTuru.Text == "Seçiniz")
            {
                MessageBox.Show("Kayıtlı Bilet Olmadığı İçin İptal Edilemez.");
                return;
            }
            else if (cboBiletFiyati.Text == "Seçiniz")
            {
                MessageBox.Show("Kayıtlı Bilet Olmadığı İçin İptal Edilemez.");
                return;
            }

            foreach (var item in db.Satislar)
            {
                if (film == item.FilmAdi)
                {
                    if (secilenTarih == item.Tarih)
                    {
                        if (secilenSeans == item.FilmSeansi)
                        {
                            if (item.KoltukNo == secilen)
                            {
                                secilenId = item.SatisId;
                            }
                        }
                    }
                }

            }

            var silinecekKoltuk = db.Satislar.Where(x => x.SatisId == secilenId).FirstOrDefault();

            if (secilenId > 0)
            {
                DialogResult dr = MessageBox.Show
                (
                "Seçili bilet iptal edilecektir. Onaylıyor musunuz?",
                "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                     );


                if (dr == DialogResult.Yes)
                {
                    db.Satislar.Remove(silinecekKoltuk);
                    sec.ImageKey = "Bos";
                    db.SaveChanges();
                }
            }

            DialogResult = DialogResult.OK;
        }
    }
}
