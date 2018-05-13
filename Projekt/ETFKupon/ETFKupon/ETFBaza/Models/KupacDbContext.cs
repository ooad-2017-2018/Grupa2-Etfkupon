using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using Windows.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ETFKupon.ETFBaza.Models
{
    class KupacDbContext : DbContext
    {
        //svi kupci iz tabele se cuvaju ovdje
        public DbSet<Kupac> Kupci { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "Etfkuponbaza.db";
            try
            {
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, databaseFilePath);
            }
            catch (InvalidOperationException)
            { }

            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Kupac>().Property(p => p.Slika).HasColumnType("image");
        }
    }
}
