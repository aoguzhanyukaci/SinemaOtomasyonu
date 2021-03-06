using SinemaOtomasyonuMaster.Data;
using Sitecore.FakeDb;
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
    public partial class SatisListelemeForm : Form
    {
        SinemaOtomasyonuDbContext db;

        public SatisListelemeForm(SinemaOtomasyonuDbContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dgvListele.Rows.Clear();
            lblTamBiletAdet.Text = "00";
            lblOgrenciBiletAdet.Text = "00";
            lblToplamBilet.Text = "00";
            lblNakitBilet.Text = "00";
            lblKrediKartiBilet.Text = "00";
            lblTamFiyat.Text = "00";
            lblOgrenciFiyati.Text = "00";
            lblToplamSatis.Text = "00";

            foreach (var item in db.Satislar)
            {
                if (dtpTarih.Text == item.Tarih2)
                {
                    dgvListele.Rows.Add(item.KoltukNo, item.SalonAdi, item.FilmAdi, item.Tarih2, item.FilmSeansi, item.OdemeTuru, item.UcretOgrenci, item.UcretNormal);
                }
            }

            if (dgvListele.Rows.Count == 0)
            {
                MessageBox.Show("Seçili Tarihde Herangi Satış İşlemi Yapılmamış.");
                return;
            }

            BiletleriListele();
        }

        private void BiletleriListele()
        {
            int tamBilet = 0;
            int ogrenciBilet = 0;
            int toplamBilet = 0;
            int krediKartı = 0;
            int nakit = 0;
            int tamBiletFiyat = 0;
            int ogrenciBiletFiyat = 0;
            int toplamBiletSatisi = 0;

            foreach (var item in db.Satislar)
            {
                if (dtpTarih.Text == item.Tarih2)
                {
                    if (item.UcretNormal == "₺20,00")
                    {
                        tamBilet += 1;
                        tamBiletFiyat += 20;
                    }
                    else if (item.UcretOgrenci == "₺15,00")
                    {
                        ogrenciBilet += 1;
                        ogrenciBiletFiyat += 15;
                    }
                   
                    if (item.OdemeTuru == "Nakit")
                    {
                        nakit += 1;
                    }
                    else if (item.OdemeTuru == "Kredi Kartı")
                    {
                        krediKartı += 1;
                    }
                }
            }

            toplamBilet = tamBilet + ogrenciBilet;
            toplamBiletSatisi = tamBiletFiyat + ogrenciBiletFiyat;
            lblTamBiletAdet.Text = tamBilet.ToString();
            lblOgrenciBiletAdet.Text = ogrenciBilet.ToString();
            lblToplamBilet.Text = toplamBilet.ToString();
            lblKrediKartiBilet.Text = krediKartı.ToString();
            lblNakitBilet.Text = nakit.ToString();
            lblTamFiyat.Text = tamBiletFiyat.ToString("c2");
            lblOgrenciFiyati.Text = ogrenciBiletFiyat.ToString("c2");
            lblToplamSatis.Text = toplamBiletSatisi.ToString("c2");
        }

        private void btnToplamSatisListele_Click(object sender, EventArgs e)
        {
            dgvToplamListele.Rows.Clear();
            lblTamBiletAdet.Text = "00";
            lblOgrenciBiletAdet.Text= "00";
            lblToplamBilet.Text = "00";
            lblNakitBilet.Text = "00";
            lblKrediKartiBilet.Text = "00";
            lblTamFiyat.Text = "00";
            lblOgrenciFiyati.Text = "00";
            lblToplamSatis.Text = "00";

            int tamBilet = 0;
            int ogrenciBilet = 0;
            int toplamBilet = 0;
            int krediKartı = 0;
            int nakit = 0;
            int tamBiletFiyat = 0;
            int ogrenciBiletFiyat = 0;
            int toplamBiletSatisi = 0;

            foreach (var item in db.Satislar)
            {
                dgvToplamListele.Rows.Add(item.KoltukNo, item.SalonAdi, item.FilmAdi, item.Tarih2, item.FilmSeansi, item.OdemeTuru, item.UcretOgrenci, item.UcretNormal);

                if (item.UcretNormal == "₺20,00")
                {
                    tamBilet += 1;
                    tamBiletFiyat += 20;
                }
                else if (item.UcretOgrenci == "₺15,00")
                {
                    ogrenciBilet += 1;
                    ogrenciBiletFiyat += 15;
                }

                if (item.OdemeTuru == "Nakit")
                {
                    nakit += 1;
                }
                else if (item.OdemeTuru == "Kredi Kartı")
                {
                    krediKartı += 1;
                }
            }

            toplamBilet = tamBilet + ogrenciBilet;
            toplamBiletSatisi = tamBiletFiyat + ogrenciBiletFiyat;
            lblSatisTam.Text = tamBilet.ToString();
            lblSatisOgrenci.Text = ogrenciBilet.ToString();
            LblSatisTamm.Text = toplamBilet.ToString();
            lblSatisKrediKarti.Text = krediKartı.ToString();
            lblSatisNakit.Text = nakit.ToString();
            lblSatisTamBilet.Text = tamBiletFiyat.ToString("c2");
            lblSatisOgrenciBilet.Text = ogrenciBiletFiyat.ToString("c2");
            lblSatisTammms.Text = toplamBiletSatisi.ToString("c2");
        }
    }
}
