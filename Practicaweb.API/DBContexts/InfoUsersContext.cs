using Microsoft.EntityFrameworkCore;
using Practicaweb.API.Entities;

namespace Practicaweb.API.DBContexts
{
    public class InfoUsersContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Bill> bills { get; set; }
        public InfoUsersContext(DbContextOptions<InfoUsersContext> options) : base(options) // Se llama al constructor de DbContext
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var users = new User[3]
            {
                new User("Usuario 1")
                {
                    Id = 1,
                    Name = "User 1",
                },
                new User("Usuario 2")
                {
                    Id = 2,
                    Name = "user 2",
                },
                new User("Admin")
                {
                    Id= 3,
                    Name = "User 3",
                }
            };
            modelBuilder.Entity<User>().HasData(users);

            modelBuilder.Entity<Bill>().HasData(
                new Bill("Nick Gaturro Cotillon")
                {
                    Id = 1,
                    Name = "Nick Gaturro Cotillon",
                    CUIT = 1254769865,
                    Price = 15885.20,
                    Description = "15 fusiles AR15",
                    UserId = users[0].Id,
                },
                new Bill("Nick Gaturro Cotillon")
                {
                    Id = 2,
                    Name = "COTO",
                    CUIT = 6986556654,
                    Price = 52000.55,
                    Description = "4 peras",
                    UserId = users[0].Id,
                },
                new Bill("Nick Gaturro Cotillon")
                {
                    Id = 3,
                    Name = "Easy",
                    CUIT = 1125446852,
                    Price = 41000.33,
                    Description = "20 Ficus con maceta",
                    UserId = users[1].Id,
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
