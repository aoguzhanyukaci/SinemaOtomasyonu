using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonuMaster.Data
{
    public class SinemaOtomasyonuDbContext : DbContext
    {
        public SinemaOtomasyonuDbContext() : base("SinemaContext")
        {
           //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SinemaOtomasyonuDbContext>());
        }

        public DbSet<Film> Filmler { get; set; }
        public DbSet<Seans> Seanslar { get; set; }
        public DbSet<Salon> Salonlar { get; set; }
        public DbSet<Satis> Satislar { get; set; }


    }


}
