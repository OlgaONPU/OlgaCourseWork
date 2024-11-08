using DataLayer.Models.Entity;
using Microsoft.EntityFrameworkCore;
using OlgaCourseWork.DataLayer.Models.Entity;

namespace DataLayer
{
    public class PrometeiDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Fireplace> Fireplaces { get; set; }
        public DbSet<Door> Doors { get; set; }
        public DbSet<Accessory> Accessories { get; set; }
        public DbSet<HeatingSystem> HeatingSystems { get; set; }
        public DbSet<Order> Orders { get; set; }

        public PrometeiDbContext(DbContextOptions<PrometeiDbContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();

            DataInitializer.Seed(this);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Orders");
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Fireplace>().ToTable("Fireplaces");
            modelBuilder.Entity<Door>().ToTable("Doors");
            modelBuilder.Entity<Accessory>().ToTable("Accessories");
            modelBuilder.Entity<HeatingSystem>().ToTable("HeatingSystems");

            modelBuilder.Entity<Fireplace>()
                .OwnsOne(f => f.Description);

            modelBuilder.Entity<Door>()
                .OwnsOne(d => d.Description);

            modelBuilder.Entity<Accessory>()
                .OwnsOne(a => a.Description);

            modelBuilder.Entity<HeatingSystem>()
                .OwnsOne(h => h.Description);

            modelBuilder.Entity<Photo>().ToTable("Photos");

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Photos)
                .WithOne(p => p.Product)
                .HasForeignKey(p => p.ProductId);
        }
    }
}
