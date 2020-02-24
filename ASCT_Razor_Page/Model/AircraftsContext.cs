using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASCT_Razor_Page.Model
{
    public partial class AircraftsContext : DbContext
    {
        public AircraftsContext()
        {
        }

        public AircraftsContext(DbContextOptions<AircraftsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aircrafts> Aircrafts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=asctserver.database.windows.net;Initial Catalog=ASCT;User ID=ASCTadmin;Password=Admin1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aircrafts>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CurrState).IsUnicode(false);

                entity.Property(e => e.EcNum).IsUnicode(false);

                entity.Property(e => e.FleetType).IsUnicode(false);

                entity.Property(e => e.LruName).IsUnicode(false);

                entity.Property(e => e.LruPn).IsUnicode(false);

                entity.Property(e => e.Post).IsUnicode(false);

                entity.Property(e => e.Pre).IsUnicode(false);

                entity.Property(e => e.SoftwareName).IsUnicode(false);

                entity.Property(e => e.SoftwarePn).IsUnicode(false);

                entity.Property(e => e.TailNum).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
