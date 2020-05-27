namespace Kursovay
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDb : DbContext
    {
        public ModelDb()
            : base("name=ModelDb")
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Sdelka> Sdelka { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tovar> Tovar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Firma)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Town)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Sdelka)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tovar>()
                .Property(e => e.nameTovar)
                .IsUnicode(false);

            modelBuilder.Entity<Tovar>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<Tovar>()
                .Property(e => e.sort)
                .IsUnicode(false);

            modelBuilder.Entity<Tovar>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tovar>()
                .Property(e => e.town)
                .IsUnicode(false);

            modelBuilder.Entity<Tovar>()
                .HasMany(e => e.Sdelka)
                .WithRequired(e => e.Tovar)
                .WillCascadeOnDelete(false);
        }
    }
}
