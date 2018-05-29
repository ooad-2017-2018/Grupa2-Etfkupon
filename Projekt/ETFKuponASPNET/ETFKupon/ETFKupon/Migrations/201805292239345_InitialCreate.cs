namespace ETFKupon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artikal",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        Naziv = c.String(nullable: false),
                        Kolicina = c.Double(nullable: false),
                        Cijena = c.Double(nullable: false),
                        idKupon = c.String(),
                        idFirma = c.String(),
                        Korpa_id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Korpa", t => t.Korpa_id)
                .Index(t => t.Korpa_id);
            
            CreateTable(
                "dbo.FirmaBaza",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        Naziv = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        StanjeRacuna = c.Double(nullable: false),
                        Artikal_id = c.String(maxLength: 128),
                        Kupon_id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Artikal", t => t.Artikal_id)
                .ForeignKey("dbo.Kupon", t => t.Kupon_id)
                .Index(t => t.Artikal_id)
                .Index(t => t.Kupon_id);
            
            CreateTable(
                "dbo.Kupon",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        Postotak = c.Double(nullable: false),
                        Kolicina = c.Double(nullable: false),
                        idFirma = c.String(nullable: false),
                        Artikal_id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Artikal", t => t.Artikal_id)
                .Index(t => t.Artikal_id);
            
            CreateTable(
                "dbo.Korpa",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        idKupac = c.String(nullable: false),
                        idArtikal = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.KupacBaza",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        Ime = c.String(nullable: false),
                        Prezime = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Adresa = c.String(nullable: false),
                        BrojKartice = c.String(nullable: false),
                        StanjeRacuna = c.Double(nullable: false),
                        InteresKupca_id = c.String(maxLength: 128),
                        Korpa_id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.InteresKupca", t => t.InteresKupca_id)
                .ForeignKey("dbo.Korpa", t => t.Korpa_id)
                .Index(t => t.InteresKupca_id)
                .Index(t => t.Korpa_id);
            
            CreateTable(
                "dbo.InteresKupca",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        idKupac = c.String(nullable: false),
                        idInteres = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Interes",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        Naziv = c.String(nullable: false),
                        InteresKupca_id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.InteresKupca", t => t.InteresKupca_id)
                .Index(t => t.InteresKupca_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kupon", "Artikal_id", "dbo.Artikal");
            DropForeignKey("dbo.KupacBaza", "Korpa_id", "dbo.Korpa");
            DropForeignKey("dbo.KupacBaza", "InteresKupca_id", "dbo.InteresKupca");
            DropForeignKey("dbo.Interes", "InteresKupca_id", "dbo.InteresKupca");
            DropForeignKey("dbo.Artikal", "Korpa_id", "dbo.Korpa");
            DropForeignKey("dbo.FirmaBaza", "Kupon_id", "dbo.Kupon");
            DropForeignKey("dbo.FirmaBaza", "Artikal_id", "dbo.Artikal");
            DropIndex("dbo.Interes", new[] { "InteresKupca_id" });
            DropIndex("dbo.KupacBaza", new[] { "Korpa_id" });
            DropIndex("dbo.KupacBaza", new[] { "InteresKupca_id" });
            DropIndex("dbo.Kupon", new[] { "Artikal_id" });
            DropIndex("dbo.FirmaBaza", new[] { "Kupon_id" });
            DropIndex("dbo.FirmaBaza", new[] { "Artikal_id" });
            DropIndex("dbo.Artikal", new[] { "Korpa_id" });
            DropTable("dbo.Interes");
            DropTable("dbo.InteresKupca");
            DropTable("dbo.KupacBaza");
            DropTable("dbo.Korpa");
            DropTable("dbo.Kupon");
            DropTable("dbo.FirmaBaza");
            DropTable("dbo.Artikal");
        }
    }
}
