using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ETFKupon.Models
{
    public class DatabaseContext : DbContext 
    {
        public DatabaseContext() : base("AzureConnection") { }

        public DbSet<Artikal> Artikal { get; set; }
        public DbSet<FirmaBaza> FirmaBaza { get; set; }
        public DbSet<Interes> Interes { get; set; }
        public DbSet<InteresKupca> InteresKupca { get; set; }
        public DbSet<Korpa> Korpa { get; set; }
        public DbSet<KupacBaza> KupacBaza { get; set; }
        public DbSet<Kupon> Kupon { get; set; }
        public DbSet<ArtikalInteres> ArtikalInteres { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}