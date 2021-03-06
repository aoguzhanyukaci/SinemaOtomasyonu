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
    public partial class SeansEkleForm : Form
    {
        SinemaOtomasyonuDbContext db;
        string seans = "";

        public SeansEkleForm(SinemaOtomasyonuDbContext db)
        {
            this.db = db;
            InitializeComponent();
            FilimleriListele();
            SalonlarıListele();
        }

        private void SalonlarıListele()
        {
            cboSeansSalonSec.DataSource = db.Salonlar.ToList();
            cboSeansSalonSec.DisplayMember = "SalonAdi";
            cboSeansSalonSec.ValueMember = "SalonId";
            cboSeansSalonSec.SelectedIndex = -1;
        }

        private void FilimleriListele()
        {
            cboSeansFilmSec.DataSource = db.Filmler.ToList();
            cboSeansFilmSec.DisplayMember = "FilmAd";
            cboSeansFilmSec.ValueMember = "FilmId";
            cboSeansFilmSec.SelectedIndex = -1;
        }

        private void RadioButtonSeciliyse()
        {
            if (rb10.Checked == true)
            {
                seans = rb10.Text;
            }
            else if (rb11.Checked == true)
            {
                seans = rb11.Text;
            }
            else if (rb12.Checked == true)
            {
                seans = rb12.Text;
            }
            else if (rb13.Checked == true)
            {
                seans = rb13.Text;
            }
            else if (rb14.Checked == true)
            {
                seans = rb14.Text;
            }
            else if (rb15.Checked == true)
            {
                seans = rb15.Text;
            }
            else if (rb16.Checked == true)
            {
                seans = rb16.Text;
            }
            else if (rb17.Checked == true)
            {
                seans = rb17.Text;
            }
            else if (rb18.Checked == true)
            {
                seans = rb18.Text;
            }
            else if (rb19.Checked == true)
            {
                seans = rb19.Text;
            }
            else if (rb20.Checked == true)
            {
                seans = rb20.Text;
            }
            else if (rb21.Checked == true)
            {
                seans = rb21.Text;
            }
            else if (rb1930.Checked == true)
            {
                seans = rb1930.Text;
            }
            else if (rb2030.Checked == true)
            {
                seans = rb2030.Text;
            }
            else if (rb2130.Checked == true)
            {
                seans = rb2130.Text;
            }
            else if (rb22.Checked == true)
            {
                seans = rb22.Text;
            }
            else if (rb2230.Checked == true)
            {
                seans = rb2230.Text;
            }
            else if (rb23.Checked == true)
            {
                seans = rb23.Text;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string filmAdi = cboSeansFilmSec.Text;
            string salonAdi = cboSeansSalonSec.Text;
            string tarih = dtpSeansTarih.Text.ToString();

            RadioButtonSeciliyse();




            if (cboSeansFilmSec.Text == "")
            {
                MessageBox.Show("Lütfen Film Adı Alanını Seçiniz.");
                return;
            }
            else if (cboSeansSalonSec.Text == "")
            {
                MessageBox.Show("Lütfen Salon Adı Alanını Seçiniz.");
                return;
            }
            else if ( dtpSeansTarih.Text == "")
            {
                MessageBox.Show("Lütfen Tarih Alanını Seçiniz.");
                return;
            }
            else if (seans == "")
            {
                MessageBox.Show("Lütfen Seans Seçimi Yapınız.");
                return;
            }
            else if (seans != "")
            {
                db.Seanslar.Add(new Seans()
                {
                    FilmAdi = filmAdi,
                    SalonAdi = salonAdi,
                    Tarih = tarih,
                    SeansZamani = seans
                });
            }

            db.SaveChanges();
            MessageBox.Show("Seans Başarıyla Eklendi");
            cboSeansFilmSec.SelectedIndex = -1;
            cboSeansSalonSec.SelectedIndex = -1;
            // groupBox1.Enabled = false;
            dtpSeansTarih.Text = DateTime.Now.ToShortDateString();
            RadioButtonSeciliyseTemizle();
        }

        private void RadioButtonSeciliyseTemizle()
        {
            if (rb10.Checked == true)
            {
                rb10.Checked = false;
            }
            else if (rb11.Checked == true)
            {
                rb11.Checked = false;
            }
            else if (rb12.Checked == true)
            {
                rb12.Checked = false;
            }
            else if (rb13.Checked == true)
            {
                rb13.Checked = false;
            }
            else if (rb14.Checked == true)
            {
                rb14.Checked = false;
            }
            else if (rb15.Checked == true)
            {
                rb15.Checked = false;
            }
            else if (rb16.Checked == true)
            {
                rb16.Checked = false;
            }
            else if (rb17.Checked == true)
            {
                rb17.Checked = false;
            }
            else if (rb18.Checked == true)
            {
                rb18.Checked = false;
            }
            else if (rb19.Checked == true)
            {
                rb19.Checked = false;
            }
            else if (rb20.Checked == true)
            {
                rb20.Checked = false;
            }
            else if (rb21.Checked == true)
            {
                rb21.Checked = false;
            }
            else if (rb1930.Checked == true)
            {
                rb1930.Checked = false;
            }
            else if (rb2030.Checked == true)
            {
                rb2030.Checked = false;
            }
            else if (rb2130.Checked == true)
            {
                rb2130.Checked = false;
            }
            else if (rb22.Checked == true)
            {
                rb22.Checked = false;
            }
            else if (rb2230.Checked == true)
            {
                rb2230.Checked = false;
            }
            else if (rb23.Checked == true)
            {
                rb23.Checked = false;
            }
        }


        private void dtpSeansTarih_ValueChanged(object sender, EventArgs e)
        {
            TarihIslemleriniYap();
        }

        private void TarihIslemleriniYap()
        {
            foreach (Control item3 in groupBox1.Controls)
            {
                item3.Enabled = true;
            }


            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dtpSeansTarih.Value.ToString());

            if (yeni == bugun)
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;
                    }
                }
                TarihiKarsilastir();
            }
            else if (yeni > bugun)
            {
                TarihiKarsilastir();
            }
            else if (yeni < bugun)
            {
                MessageBox.Show("Geriye dönük işlem yapılamaz!!!");
                dtpSeansTarih.Text = DateTime.Now.ToShortDateString();
            }
            TarihiKarsilastir();
        }

        private void TarihiKarsilastir()
        {
            foreach (var item in db.Seanslar)
            {
                foreach (Control item2 in groupBox1.Controls)
                {
                    // if (item.FilmAdi == cboSeansFilmSec.Text)
                    // {
                    if (item.SalonAdi == cboSeansSalonSec.Text)
                    {
                        if (item.Tarih == dtpSeansTarih.Text)
                        {
                            if (item.SeansZamani == item2.Text)
                            {
                                item2.Enabled = false;
                            }
                        }

                    }
                    // }

                }
            }
        }

        private void cboSeansSalonSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpSeansTarih.Text = DateTime.Now.ToShortDateString();
            TarihIslemleriniYap();
        }



        private void cboSeansFilmSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            TarihIslemleriniYap();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SeansSilForm seansSilForm = new SeansSilForm(db);
            seansSilForm.ShowDialog();
        }
    }
}
