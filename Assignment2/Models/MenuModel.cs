namespace Assignment2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MenuModel : DbContext
    {
        public MenuModel()
            : base("name=MenuModel1")
        {
        }

        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.ShortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Thumbnail)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .HasOptional(e => e.MenuItem)
                .WithRequired(e => e.Menu);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.LongDescription)
                .IsUnicode(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.HighResolutionImg)
                .IsUnicode(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.Type)
                .IsUnicode(false);
        }
    }
}
