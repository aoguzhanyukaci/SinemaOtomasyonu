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
    public partial class BilgilendirmeForm : Form
    {
        SinemaOtomasyonuDbContext db;
        string film;

        public BilgilendirmeForm(string film, SinemaOtomasyonuDbContext db)
        {
            this.film = film;
            this.db = db;
            InitializeComponent();
            CbolariDoldur();
        }

        private void dgvSalon1IciniDoldur()
        {
            dgvSalon1.Rows.Clear();

            string bugun = dtpTarih.Text;
            DateTime suankiZaman = DateTime.Now;
            string suankiSaat = suankiZaman.ToString("t");

            string salon1 = "Salon-1";

            foreach (var item in db.Seanslar)
            {
                if (item.FilmAdi == film)
                {
                    if (item.Tarih == bugun)
                    {
                        if (item.SalonAdi == salon1)
                        {
                            dgvSalon1.Rows.Add(item.SeansZamani);

                        }
                    }
                }
            }
        }

        private void dgvSalon2IciniDoldur()
        {
            dgvSalon2.Rows.Clear();

            string bugun = dtpTarih.Text;
            string salon2 = "Salon-2";

            foreach (var item in db.Seanslar)
            {
                if (item.FilmAdi == film)
                {
                    if (item.Tarih == bugun)
                    {
                        if (item.SalonAdi == salon2)
                        {
                            dgvSalon2.Rows.Add(item.SeansZamani);
                        }
                    }
                }
            }
        }

        private void dgvSalon3IciniDoldur()
        {
            dgvSalon3.Rows.Clear();

            string bugun = dtpTarih.Text;
            string salon3 = "Salon-3";

            foreach (var item in db.Seanslar)
            {
                if (item.FilmAdi == film)
                {
                    if (item.Tarih == bugun)
                    {
                        if (item.SalonAdi == salon3)
                        {
                            dgvSalon3.Rows.Add(item.SeansZamani);
                        }
                    }
                }
            }
        }

        private void dgvSalon4IciniDoldur()
        {
            dgvSalon4.Rows.Clear();

            string bugun = dtpTarih.Text;
            string salon4 = "Salon-4";

            foreach (var item in db.Seanslar)
            {
                if (item.FilmAdi == film)
                {
                    if (item.Tarih == bugun)
                    {
                        if (item.SalonAdi == salon4)
                        {
                            dgvSalon4.Rows.Add(item.SeansZamani);
                        }
                    }
                }
            }
        }

        private void dgvSalon5IciniDoldur()
        {
            dgvSalon5.Rows.Clear();

            string bugun = dtpTarih.Text;
            string salon5 = "Salon-5";

            foreach (var item in db.Seanslar)
            {
                if (item.FilmAdi == film)
                {
                    if (item.Tarih == bugun)
                    {
                        if (item.SalonAdi == salon5)
                        {
                            dgvSalon5.Rows.Add(item.SeansZamani);
                        }
                    }
                }
            }
        }

        private void dgvSalon6IciniDoldur()
        {
            dgvSalon6.Rows.Clear();

            string bugun = dtpTarih.Text;
            string salon6 = "Salon-6";

            foreach (var item in db.Seanslar)
            {
                if (item.FilmAdi == film)
                {
                    if (item.Tarih == bugun)
                    {
                        if (item.SalonAdi == salon6)
                        {
                            dgvSalon6.Rows.Add(item.SeansZamani);
                        }
                    }
                }
            }
        }

        private void SeanslariListele()
        {
            DateTime yeni = DateTime.Parse(dtpTarih.Value.ToString());
            string saat = yeni.ToString("t");

            DateTime bugun = DateTime.Now;

            foreach (var item in db.Seanslar)
            {
                if (item.FilmAdi == film)
                {
                    if (item.Tarih == dtpTarih.Text)
                    {
                        if (item.SalonAdi == cboSalonSec.Text)
                        {
                            if (string.Compare(saat, item.SeansZamani, true) == -1)
                            {
                                cboSeansSec.Items.Add(item.SeansZamani);
                            }
                            else if (string.Compare(bugun.ToLongDateString(), item.Tarih, true) == -1)
                            {
                                cboSeansSec.Items.Add(item.SeansZamani);
                            }
                        }
                    }
                }
            }
        }

        private void CbolariDoldur()
        {
            cboSalonSec.DataSource = db.Salonlar.ToList();
            cboSalonSec.DisplayMember = "SalonAdi";
            cboSalonSec.ValueMember = "SalonId";
            cboSalonSec.SelectedIndex = -1;
        }


        private void BilgilendirmeForm_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Filmler)
            {
                if (item.FilmAd == film)
                {
                    pcbAfis.Image = item.Resim;
                    txtFilmHakkinda.Text = item.FilmAciklama;
                }
            }

            dgvSalon1IciniDoldur();
            dgvSalon2IciniDoldur();
            dgvSalon3IciniDoldur();
            dgvSalon4IciniDoldur();
            dgvSalon5IciniDoldur();
            dgvSalon6IciniDoldur();
        }

        private void btnKoltukSec_Click(object sender, EventArgs e)
        {
            if (cboSalonSec.Text == "")
            {
                MessageBox.Show("Lütfen salon seçimi yapınız.");
                return;
            }
            else if (cboSeansSec.Text == "")
            {
                MessageBox.Show("Lütfen seans seçimi yapınız.");
                return;
            }

            this.Hide();
            string secilenSeans = cboSeansSec.Text;
            string secilenTarih = dtpTarih.Text;
            string secilenSalon = cboSalonSec.Text;
            KoltukSecForm koltukSecForm = new KoltukSecForm(film, secilenSeans, secilenTarih, secilenSalon, db);
            koltukSecForm.ShowDialog();
        }

        private void cboSalonSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSeansSec.Items.Clear();
            SeanslariListele();
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            dgvSalon1IciniDoldur();
            dgvSalon2IciniDoldur();
            dgvSalon3IciniDoldur();
            dgvSalon4IciniDoldur();
            dgvSalon5IciniDoldur();
            dgvSalon6IciniDoldur();

        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
