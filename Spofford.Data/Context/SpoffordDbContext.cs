namespace Spofford.Data.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Spofford.Core.Domain;

    public partial class SpoffordDbContext : DbContext
    {
        public SpoffordDbContext()
            : base("name=SpoffordDbContext")
        {
        }

        public virtual DbSet<Entry> Entries { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Region> Regions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Region>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Entry>()
                .HasMany<Team>(t => t.Teams)
                .WithMany(e => e.Entries)
                .Map(et =>
                {
                    et.MapLeftKey("EntryID");
                    et.MapRightKey("TeamID");
                    et.ToTable("EntryTeams");
                });
        }
    }
}
