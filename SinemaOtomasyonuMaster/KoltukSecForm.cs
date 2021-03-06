using SinemaOtomasyonuMaster.Data;
using SinemaOtomasyonuMaster.Properties;
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
    public partial class KoltukSecForm : Form
    {

        SinemaOtomasyonuDbContext db;
        string film;
        string secilenSeans;
        string secilenTarih;
        string secilenSalon;

        public KoltukSecForm(string film, string secilenSeans, string secilenTarih, string secilenSalon, SinemaOtomasyonuDbContext db)
        {
            this.film = film;
            this.secilenSeans = secilenSeans;
            this.secilenTarih = secilenTarih;
            this.secilenSalon = secilenSalon;
            this.db = db;
            InitializeComponent();
            lblFilmAdi.Text = film;
            lblGosterimTarihi.Text = secilenTarih;
            lblSeans.Text = secilenSeans;
        }


        private void KoltukSecForm_Load(object sender, EventArgs e)
        {
            KoltuklarıYukle();
        }

        private void KoltuklarıYukle()
        {
            lvwKoltuk.Items.Clear();
            ImageList imageList = new ImageList();
            imageList.Images.Add("bos", Resources.BosKoltuk);
            imageList.Images.Add("bay", Resources.ErkekKoltuk);
            imageList.Images.Add("bayan", Resources.BayanKoltuk);
            imageList.ImageSize = new Size(40, 40);
            lvwKoltuk.LargeImageList = imageList;


            int koltuk = 10;

            for (int i = 1; i <= koltuk; i++)
            {
                ListViewItem lvi = new ListViewItem("A" + i);
                lvi.ImageKey = "bos";
                string koltukcu = "A" + i;

                foreach (var item in db.Satislar)
                {
                    if (film == item.FilmAdi)
                    {
                        if (secilenTarih == item.Tarih)
                        {
                            if (secilenSeans == item.FilmSeansi)
                            {
                                if (item.KoltukNo == koltukcu)
                                {
                                    if (item.Cinsiyet == "Bay")
                                    {
                                        lvi.ImageKey = "bay";
                                    }
                                    else if (item.Cinsiyet == "Bayan")
                                    {
                                        lvi.ImageKey = "bayan";
                                    }
                                    else if (item.Cinsiyet == "Seçiniz")
                                    {
                                        lvi.ImageKey = "bos";
                                    }
                                }
                            }
                        }
                    }

                }

                lvi.Tag = "A" + i;
                lvwKoltuk.Items.Add(lvi);
            }

            for (int j = 1; j <= koltuk; j++)
            {

                ListViewItem lvi = new ListViewItem("B" + j);
                lvi.ImageKey = "bos";
                string koltukcu = "B" + j;

                foreach (var item in db.Satislar)
                {
                    if (film == item.FilmAdi)
                    {
                        if (secilenTarih == item.Tarih)
                        {
                            if (secilenSeans == item.FilmSeansi)
                            {
                                if (item.KoltukNo == koltukcu)
                                {
                                    if (item.Cinsiyet == "Bay")
                                    {
                                        lvi.ImageKey = "bay";
                                    }
                                    else if (item.Cinsiyet == "Bayan")
                                    {
                                        lvi.ImageKey = "bayan";
                                    }
                                }
                            }
                        }
                    }

                }

                lvi.Tag = "B" + j;
                lvwKoltuk.Items.Add(lvi);
            }

            for (int a = 1; a <= koltuk; a++)
            {
                ListViewItem lvi = new ListViewItem("C" + a);
                lvi.ImageKey = "bos";
                string koltukcu = "C" + a;

                foreach (var item in db.Satislar)
                {
                    if (film == item.FilmAdi)
                    {
                        if (secilenTarih == item.Tarih)
                        {
                            if (secilenSeans == item.FilmSeansi)
                            {
                                if (koltukcu == item.KoltukNo)
                                {
                                    if (item.Cinsiyet == "Bay")
                                    {
                                        lvi.ImageKey = "bay";
                                    }
                                    else if (item.Cinsiyet == "Bayan")
                                    {
                                        lvi.ImageKey = "bayan";
                                    }
                                }
                            }
                        }
                    }

                }

                lvi.Tag = "C" + a;
                lvwKoltuk.Items.Add(lvi);
            }

            for (int b = 1; b <= koltuk; b++)
            {
                ListViewItem lvi = new ListViewItem("D" + b);
                lvi.ImageKey = "bos";
                string koltukcu = "D" + b;

                foreach (var item in db.Satislar)
                {
                    if (film == item.FilmAdi)
                    {
                        if (secilenTarih == item.Tarih)
                        {
                            if (secilenSeans == item.FilmSeansi)
                            {
                                if (item.KoltukNo == koltukcu)
                                {
                                    if (item.Cinsiyet == "Bay")
                                    {
                                        lvi.ImageKey = "bay";
                                    }
                                    else if (item.Cinsiyet == "Bayan")
                                    {
                                        lvi.ImageKey = "bayan";
                                    }
                                }
                            }
                        }
                    }

                }

                lvi.Tag = "D" + b;
                lvwKoltuk.Items.Add(lvi);
            }

            for (int e = 1; e <= koltuk; e++)
            {
                ListViewItem lvi = new ListViewItem("E" + e);
                lvi.ImageKey = "bos";
                string koltukcu = "E" + e;

                foreach (var item in db.Satislar)
                {
                    if (film == item.FilmAdi)
                    {
                        if (secilenTarih == item.Tarih)
                        {
                            if (secilenSeans == item.FilmSeansi)
                            {
                                if (item.KoltukNo == koltukcu)
                                {
                                    if (item.Cinsiyet == "Bay")
                                    {
                                        lvi.ImageKey = "bay";
                                    }
                                    else if (item.Cinsiyet == "Bayan")
                                    {
                                        lvi.ImageKey = "bayan";
                                    }
                                }
                            }
                        }
                    }

                }

                lvi.Tag = "E" + e;
                lvwKoltuk.Items.Add(lvi);
            }

            for (int g = 1; g <= koltuk; g++)
            {
                ListViewItem lvi = new ListViewItem("F" + g);
                lvi.ImageKey = "bos";
                string koltukcu = "F" + g;

                foreach (var item in db.Satislar)
                {
                    if (film == item.FilmAdi)
                    {
                        if (secilenTarih == item.Tarih)
                        {
                            if (secilenSeans == item.FilmSeansi)
                            {
                                if (item.KoltukNo == koltukcu)
                                {
                                    if (item.Cinsiyet == "Bay")
                                    {
                                        lvi.ImageKey = "bay";
                                    }
                                    else if (item.Cinsiyet == "Bayan")
                                    {
                                        lvi.ImageKey = "bayan";
                                    }
                                }
                            }
                        }
                    }

                }

                lvi.Tag = "F" + g;
                lvwKoltuk.Items.Add(lvi);
            }

            for (int z = 1; z <= koltuk; z++)
            {
                ListViewItem lvi = new ListViewItem("G" + z);
                lvi.ImageKey = "bos";
                string koltukcu = "G" + z;

                foreach (var item in db.Satislar)
                {
                    if (film == item.FilmAdi)
                    {
                        if (secilenTarih == item.Tarih)
                        {
                            if (secilenSeans == item.FilmSeansi)
                            {
                                if (item.KoltukNo == koltukcu)
                                {
                                    if (item.Cinsiyet == "Bay")
                                    {
                                        lvi.ImageKey = "bay";
                                    }
                                    else if (item.Cinsiyet == "Bayan")
                                    {
                                        lvi.ImageKey = "bayan";
                                    }
                                }
                            }
                        }
                    }

                }


                lvi.Tag = "G" + z;
                lvwKoltuk.Items.Add(lvi);
            }



        }

        string secilen;
        private void lvwKoltuk_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string tag = (string)lvwKoltuk.SelectedItems[0].Tag;
            ListViewItem sec = lvwKoltuk.SelectedItems[0];
            secilen = (string)sec.Tag;
            // Satis satis = db.Satislar.FirstOrDefault(x => x.KoltukNo == secilen);
            SatınAlmaIslemiForm satınAlmaIslemi = new SatınAlmaIslemiForm(sec, film, secilen, secilenSeans, secilenTarih, secilenSalon,db);
            satınAlmaIslemi.ShowDialog();
            lvwKoltuk.Refresh();
        }


    }
}
