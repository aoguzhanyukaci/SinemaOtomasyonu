using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonuMaster.Data
{
    [Table("Satislar")]
    public class Satis
    {
        public int SatisId { get; set; }
        public string KoltukNo { get; set; }
        public string SalonAdi { get; set; }
        public string FilmAdi { get; set; }
        public string Tarih { get; set; }
        public string Cinsiyet { get; set; }
        public string FilmSeansi { get; set; }
        public string UcretNormal { get; set; }
        public string UcretOgrenci { get; set; }
        public string OdemeTuru { get; set; }
        public string Tarih2 { get; set; }
        public int CinsiyetDurum { get; set; }
        public int OdemeDurum { get; set; }
    }
}
