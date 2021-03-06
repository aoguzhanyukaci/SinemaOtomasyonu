using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonuMaster.Data
{
    [Table("Filimler")]
    public class Film
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FilmId { get; set; }
        [Required, MaxLength(50)]
        public string FilmAd { get; set; }
        [Required, MaxLength(50)]
        public string FilmTur { get; set; }
        [Required, MaxLength(50)]
        public string Yonetmen { get; set; }
        [Required, MaxLength(50)]
        public string FilmSüresi { get; set; }
        [Required, MaxLength]
        public string FilmAciklama { get; set; }
        [Required, MaxLength(50)]
        public string YapimYili { get; set; }
        [Required, MaxLength(50)]
        public string Tarih { get; set; }
        [Required, MaxLength]
        public string FilmResim { get; set; }
        public bool FilmDurumu { get; set; }


        [NotMapped]
        public Image Resim
        {
            get
            {
                if (!string.IsNullOrEmpty(FilmResim))
                {
                    if (File.Exists(FilmResim))
                        return Image.FromFile(FilmResim);
                }
                return null;
            }
        }


    }
}