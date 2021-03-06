using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonuMaster.Data
{
    [Table("Salonlar")]
    public class Salon
    {
        public int SalonId { get; set; }
        [Required, MaxLength(30)]
        public string SalonAdi { get; set; }
    }
}
