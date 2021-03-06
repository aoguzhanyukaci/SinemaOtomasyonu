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
    public partial class Form1 : Form
    {
        SinemaOtomasyonuDbContext db = new SinemaOtomasyonuDbContext();
        ImageList imageList = new ImageList();

        public Form1()
        {
            InitializeComponent();
            lvwFilmler.LargeImageList = imageList;
            imageList.ImageSize = new Size(146, 194);
            FilimleriListele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SeanlarıKayanYaziyaYukle();
            timer1.Enabled = true;
        }

        int kayanYaziSayac = 1;

        string yazi1 = "";
        string yazi2 = "";
        string yazi3 = "";

        private void SeanlarıKayanYaziyaYukle()
        {
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime tarih = DateTime.Now;
            string saat = tarih.ToString("t");

            string degisken1 = "";
            string degisken2 = "";
            string degisken3 = "";
            string degisken4 = "";
            string degisken5 = "";
            string degisken6 = "";
            string degisken7 = "";
            string degisken8 = "";
            string degisken9 = "";
            string degisken10 = "";
            string degisken11 = "";
            string degisken12 = "";
            string degisken13 = "";
            string degisken14 = "";
            string degisken15 = "";
            int sayac = 1;




            foreach (var item in db.Seanslar)
            {
                if (item.Tarih == bugun.ToString("D"))
                {
                    if (string.Compare(saat, item.SeansZamani, true) == -1)
                    {
                        switch (sayac)
                        {
                            case 1:
                                degisken1 = (item.FilmAdi + " - " + item.SalonAdi + " - " + item.SeansZamani);
                                sayac++;
                                kayanYaziBoyutu1 += 275;
                                break;
                            case 2:
                                degisken2 = (item.FilmAdi + " - " + item.SalonAdi + " - " + item.SeansZamani);
                                sayac++;
                                kayanYaziBoyutu1 += 275;
                                break;
                            case 3:
                                degisken3 = (item.FilmAdi + " - " + item.SalonAdi + " - " + item.SeansZamani);
                                sayac++;
                                kayanYaziBoyutu1 += 275;
                                break;
                            case 4:
                                degisken4 = (item.FilmAdi + " - " + item.SalonAdi + " - " + item.SeansZamani);
                                sayac++;
                                kayanYaziBoyutu1 += 275;
                                break;
                            case 5:
                                degisken5 = (item.FilmAdi + " - " + item.SalonAdi + " - " + item.SeansZamani);
                                sayac++;
                                kayanYaziBoyutu1 += 275;
                                break;
                            case 6:
                                degisken6 = (item.FilmAdi + " - " + item.SalonAdi + " - " + item.SeansZamani);
                                sayac++;
                                kayanYaziBoyutu2 += 275;
                                break;
                            case 7:
                                degisken7 = (item.FilmAdi + " - " + item.SalonAdi + " - " + item.SeansZamani);
                                sayac++;
                                kayanYaziBoyutu2 += 275;
                                break;
                            case 8:
                                degisken8 = (item.FilmAdi + " - " + item.SalonAdi + " - " + item.SeansZamani);
                                sayac++;
                                kayanYaziBoyutu2 += 275;
                                break;
                            case 9:
                                degisken9 = (item.FilmAdi + " - " + item.SalonAdi + " - " + item.SeansZamani);
                                sayac++;
                                kayanYaziBoyutu2 += 275;
                                break;
                            case 10:
                                degisken10 = (item.FilmAdi + " - " + item.SalonAdi + " - " + item.SeansZamani);
                                sayac++;
                                kayanYaziBoyutu2 += 275;
                                break;
                            case 11:
                                degisken11 = (item.FilmAdi + " - " + item.SalonAdi + " - " + item.SeansZamani);
                                sayac++;
                                kayanYaziBoyutu3 += 275;
                                break;
                            case 12:
                                degisken12 = (item.FilmAdi + " - " + item.SalonAdi + " - " + item.SeansZamani);
                                sayac++;
                                kayanYaziBoyutu3 += 275;
                                break;
                            case 13:
                                degisken13 = (item.FilmAdi + " - " + item.SalonAdi + " - " + item.SeansZamani);
                                sayac++;
                                kayanYaziBoyutu3 += 275;
                                break;
                            case 14:
                                degisken14 = (item.FilmAdi + " - " + item.SalonAdi + " - " + item.SeansZamani);
                                sayac++;
                                kayanYaziBoyutu3 += 275;
                                break;
                            case 15:
                                degisken15 = (item.FilmAdi + " - " + item.SalonAdi + " - " + item.SeansZamani);
                                sayac++;
                                kayanYaziBoyutu3 += 275;
                                break;

                        }
                    }

                    //label1.Text = (" -- " + item.FilmAdi + " -- " + item.SalonAdi + " -- " + item.Tarih + " -- " + item.SeansZamani + " -- ");
                }

                yazi1 = degisken1 + "        " + degisken2 + "        " + degisken3 + "        " + degisken4 + "        " + degisken5;


                yazi2 = degisken6 + "        " + degisken7 + "        " + degisken8 + "        " + degisken9 + "        " + degisken10;

                yazi3 = degisken11 + "        " + degisken12 + "        " + degisken13 + "        " + degisken14 + "        " + degisken15;

                //+"        " + degisken6 + "        " + degisken7 + "        " + degisken8 + "        " + degisken9 + "        " + degisken10 + "        " + degisken11 + "        " + degisken12 + "        " + degisken13 + "        " + degisken14 + "        " + degisken15;

                label1.Text = yazi1;
            }
        }


        private void FilimleriListele()
        {
            lvwFilmler.Items.Clear();
            imageList.Images.Clear();

            foreach (var item in db.Filmler)
            {
                if (item.FilmDurumu == true)
                {
                    ListViewItem ekle = new ListViewItem(item.FilmId.ToString());
                    ekle.ImageKey = item.FilmResim;
                    ekle.Text = item.FilmAd;
                    ekle.Tag = item.FilmAd;
                    imageList.Images.Add(item.FilmResim, item.Resim);
                    lvwFilmler.Items.Add(ekle);
                }
                else
                {
                    continue;
                }
            }
            lvwFilmler.Refresh();

        }

        private void destekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DestekForm destekForm = new DestekForm();
            destekForm.ShowDialog();
        }

        private void lvwFilmler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string film = (string)lvwFilmler.SelectedItems[0].Tag;
            ListViewItem sec = lvwFilmler.SelectedItems[0];
            string secilen = (string)sec.Tag;
            var git = db.Filmler.FirstOrDefault(x => x.FilmAd == secilen);



            BilgilendirmeForm blgFrm = new BilgilendirmeForm(film, db);
            blgFrm.ShowDialog();
            //FilimleriListele();
        }


        private void filmEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmEkleForm filmEkleForm = new FilmEkleForm(db);
            filmEkleForm.ShowDialog();
            lvwFilmler.Items.Clear();
            FilimleriListele();
        }

        private void seansEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeansEkleForm seansEkle = new SeansEkleForm(db);
            seansEkle.ShowDialog();
            SeanlarıKayanYaziyaYukle();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblSeansListele_Click(object sender, EventArgs e)
        {
            SeansListelemeForm seansListeleme = new SeansListelemeForm(db);
            seansListeleme.ShowDialog();
        }

        private void satışlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisListelemeForm satisListelemeForm = new SatisListelemeForm(db);
            satisListelemeForm.ShowDialog();
        }

        private void seanslarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeansListelemeForm seansListeleme = new SeansListelemeForm(db);
            seansListeleme.ShowDialog();
        }

        int kayanYaziBoyutu1 = 0;
        int kayanYaziBoyutu2 = 0;
        int kayanYaziBoyutu3 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (kayanYaziSayac == 1)
            {
                if (label1.Left > -kayanYaziBoyutu1)
                {
                    label1.Left -= 1;
                }
                else
                {
                    label1.Text = "";
                    label1.Left = 0;
                    kayanYaziBoyutu1 = 0;
                    label1.Text = yazi2;
                    kayanYaziSayac++;
                }
            }
            else if (kayanYaziSayac == 2)
            {
                if (label1.Left > -kayanYaziBoyutu2)
                {
                    label1.Left -= 1;
                }
                else
                {
                    label1.Text = "";
                    label1.Left = 0;
                    kayanYaziBoyutu2 = 0;
                    label1.Text = yazi3;
                    kayanYaziSayac++;
                }
            }
            else if (kayanYaziSayac == 3)
            {
                if (label1.Left > -kayanYaziBoyutu3)
                {
                    label1.Left -= 1;
                }
                else
                {
                    label1.Text = "";
                    label1.Left = 0;
                    kayanYaziBoyutu3 = 0;
                    label1.Text = yazi1;
                    kayanYaziSayac = 1;
                    SeanlarıKayanYaziyaYukle();
                }
            }


            //else
            //{
            //    label1.Text = "";
            //    label1.Left = 0;
            //    label1.Text = yazi1;
            //    kayanYaziSayac = 1;
            //}



            //if (label1.Left > -kayanYaziBoyutu1)
            //{
            //    label1.Left -= 1;
            //}
            //else
            //{
            //    label1.Text = "";
            //    label1.Left = kayanYaziBoyutu1;
            //}
            //if (label1.Left > -kayanYaziBoyutu2)
            //{
            //    label1.Left -= 1;
            //}


            //else
            //{
            //    label1.Left = kayanYaziBoyutu;
            //}
        }

    }
}
