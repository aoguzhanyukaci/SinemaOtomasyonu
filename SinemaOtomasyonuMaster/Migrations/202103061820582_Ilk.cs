namespace SinemaOtomasyonuMaster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Filimler",
                c => new
                    {
                        FilmId = c.Int(nullable: false, identity: true),
                        FilmAd = c.String(nullable: false, maxLength: 50),
                        FilmTur = c.String(nullable: false, maxLength: 50),
                        Yonetmen = c.String(nullable: false, maxLength: 50),
                        FilmSüresi = c.String(nullable: false, maxLength: 50),
                        FilmAciklama = c.String(nullable: false),
                        YapimYili = c.String(nullable: false, maxLength: 50),
                        Tarih = c.String(nullable: false, maxLength: 50),
                        FilmResim = c.String(nullable: false),
                        FilmDurumu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FilmId);
            
            CreateTable(
                "dbo.Salonlar",
                c => new
                    {
                        SalonId = c.Int(nullable: false, identity: true),
                        SalonAdi = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.SalonId);
            
            CreateTable(
                "dbo.Satislar",
                c => new
                    {
                        SatisId = c.Int(nullable: false, identity: true),
                        KoltukNo = c.String(),
                        SalonAdi = c.String(),
                        FilmAdi = c.String(),
                        Tarih = c.String(),
                        Cinsiyet = c.String(),
                        FilmSeansi = c.String(),
                        UcretNormal = c.String(),
                        UcretOgrenci = c.String(),
                        OdemeTuru = c.String(),
                        Tarih2 = c.String(),
                        CinsiyetDurum = c.Int(nullable: false),
                        OdemeDurum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SatisId);
            
            CreateTable(
                "dbo.Seanslar",
                c => new
                    {
                        SeansId = c.Int(nullable: false, identity: true),
                        FilmAdi = c.String(nullable: false, maxLength: 50),
                        SalonAdi = c.String(nullable: false, maxLength: 50),
                        Tarih = c.String(nullable: false, maxLength: 50),
                        SeansZamani = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.SeansId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Seanslar");
            DropTable("dbo.Satislar");
            DropTable("dbo.Salonlar");
            DropTable("dbo.Filimler");
        }
    }
}
