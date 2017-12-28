using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace codeFirst.Models
{
    public class OTODbContext : DbContext
    {
        public DbSet<Buses> Buses { get; set; }
        public DbSet<Stations> Stations { get; set; }
        public DbSet<Seferler> Seferler { get; set; }
        public DbSet<BusSefer> BusSefer { get; set; }
        public DbSet<BusStation> BusStation { get; set; }

        public OTODbContext() : base("Data Source=DESKTOP-SON6OA8;Initial Catalog=Oto;Integrated Security=True")
        {
            Database.SetInitializer<OTODbContext>(new DbInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusSefer>().ToTable("Olustur");
            modelBuilder.Entity<BusStation>().ToTable("Gider");

            modelBuilder.Entity<Buses>().Property(d => d.BusName).HasMaxLength(15);
            modelBuilder.Entity<Stations>().Property(d => d.StationName).HasMaxLength(25);

            base.OnModelCreating(modelBuilder);

        }

        public class DbInitializer : DropCreateDatabaseAlways<OTODbContext>
        {
            protected override void Seed(OTODbContext context)
            {

                Buses oto1 = new Buses
                {
                    BusName = "3NBJF"

                };
                Buses oto2 = new Buses
                {
                    BusName = "5sjdjd"
                };
                context.Buses.Add(oto1);
                context.Buses.Add(oto2);

                context.SaveChanges();
                base.Seed(context);

            }
        }

    }
}