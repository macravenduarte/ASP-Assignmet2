namespace Assignment2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MenuContext : DbContext
    {
        public MenuContext()
            : base("name=MenuConnection")
        {
        }

        public virtual DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuItem>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.ShortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.LongDescrition)
                .IsUnicode(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.Thumbnail)
                .IsUnicode(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.HighResolution)
                .IsUnicode(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.ItemType)
                .IsUnicode(false);
        }
    }
}
