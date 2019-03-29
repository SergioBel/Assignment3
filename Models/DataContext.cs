namespace Assignment3WADB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=MusicShop")
        {
        }

        public virtual DbSet<Instrument> Instruments { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instrument>()
                .Property(e => e.instrumentName)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.jobName)
                .IsUnicode(false);

            modelBuilder.Entity<Worker>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<Worker>()
                .Property(e => e.lastName)
                .IsUnicode(false);
        }
    }
}
