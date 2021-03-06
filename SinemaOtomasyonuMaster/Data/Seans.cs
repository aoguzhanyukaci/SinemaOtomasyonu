using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonuMaster.Data
{
    [Table("Seanslar")]
    public class Seans
    {
        public int SeansId { get; set; }
        
        [Required, MaxLength(50)]
        public string FilmAdi { get; set; }
        [Required, MaxLength(50)]
        public string SalonAdi { get; set; }
        [Required, MaxLength(50)]
        public string Tarih { get; set; }
        [Required, MaxLength(50)]
        public string SeansZamani { get; set; }


    }
}
