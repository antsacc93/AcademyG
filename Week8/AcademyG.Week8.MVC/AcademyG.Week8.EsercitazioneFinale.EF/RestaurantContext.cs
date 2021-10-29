using AcademyG.Week8.EsercitazioneFinale.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace AcademyG.Week8.EsercitazioneFinale.EF
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Menu> Menus { get; set; }

        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>().HasKey(i => i.Id);
            modelBuilder.Entity<Dish>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Dish>().Property(p => p.Description).IsRequired();
            modelBuilder.Entity<Dish>().Property(p => p.DishType).IsRequired();
            modelBuilder.Entity<Dish>().Property(p => p.Price).IsRequired();
            modelBuilder.Entity<Dish>().HasOne(x => x.Menu).WithMany(x => x.Dishes);

            modelBuilder.Entity<User>().HasKey(i => i.Id);
            modelBuilder.Entity<User>().HasIndex(u => u.Username).IsUnique();
            modelBuilder.Entity<User>().Property(u => u.Username).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Password).IsRequired();

            


            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "mrossi@abc.it", Password = "1234", Role = Role.Caterer },
                new User { Id = 2, Username = "antonias.@abc.it", Password = "5678", Role = Role.Customer }
            );

            var menuEntity = modelBuilder.Entity<Menu>();
            menuEntity.HasKey(x => x.Id);
            menuEntity.Property(x => x.Name).IsRequired();
            menuEntity.HasMany(x => x.Dishes)
                      .WithOne(x => x.Menu);

            menuEntity.HasData(new Menu
            {
                Id = 1,
                Name = "Menu di Natale"
            });


        }
    }
}
