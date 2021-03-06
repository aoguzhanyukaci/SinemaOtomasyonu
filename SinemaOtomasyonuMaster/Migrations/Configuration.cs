namespace SinemaOtomasyonuMaster.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SinemaOtomasyonuMaster.Data.SinemaOtomasyonuDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SinemaOtomasyonuMaster.Data.SinemaOtomasyonuDbContext";
        }

        protected override void Seed(SinemaOtomasyonuMaster.Data.SinemaOtomasyonuDbContext context)
        {
            if (!context.Salonlar.Any())
            {
                context.Salonlar.Add(new Data.Salon() { SalonAdi="Salon-1"});
                context.Salonlar.Add(new Data.Salon() { SalonAdi="Salon-2"});
                context.Salonlar.Add(new Data.Salon() { SalonAdi="Salon-3"});
                context.Salonlar.Add(new Data.Salon() { SalonAdi="Salon-4"});
                context.Salonlar.Add(new Data.Salon() { SalonAdi="Salon-5"});
                context.Salonlar.Add(new Data.Salon() { SalonAdi="Salon-6"});
            }
        }
    }
}
