using AnimalShelter;
using AnimalShelterCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins.DataAnimals.Sql.Repositories
{
    public class AnimalShelterDbContext : IdentityDbContext
    {
        public AnimalShelterDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ClientOrder> ClientOrders { get; set; }       

        public DbSet<Section> Sections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            IdentityRole identityRole = new IdentityRole();
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "User", NormalizedName = "USER", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });

          //  modelBuilder.Entity<UserLoginInfo>().HasData(new IdentityUserRole { RoleId = identityRole.Id.Where(identityRole.Name == "Admin"), UserId = "749bbe1e-d5f4-45f6-93ba-4d036ccccc22" });
            
            modelBuilder.Entity<Category>()
                .HasMany(x => x.Animals)
                .WithOne(y => y.Category)
                .HasForeignKey(f => f.CategoryId);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Cats"
                },

                new Category
                {
                    CategoryId = 2,
                    Name = "Dogs"
                }
            );       
        }
    }
}
