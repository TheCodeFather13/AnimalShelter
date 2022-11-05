using AnimalShelter;
using AnimalShelterCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins.DataAnimals.Sql.Repositories
{
    public class AnimalShelterDbContext : DbContext
    {
        public AnimalShelterDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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

            modelBuilder.Entity<Animal>().HasData(
                new Animal()
                {
                    AnimalId = 1,
                    CategoryId = 1,
                    Name = "Муся",
                    Gender = "Female",
                    Age = "1 месяц",
                    DayOfPublication = DateTime.UtcNow,
                    Contacts = "Maria 079245611",
                    ImagePath = "css/Images/Cat1.jpg"
                },

                 new Animal()
                 {
                     AnimalId = 2,
                     CategoryId = 1,
                     Name = "Вася",
                     Gender = "Male",
                     Age = "5 месяцев",
                     DayOfPublication = DateTime.UtcNow,
                     Contacts = "Svetlana 069367315",
                     ImagePath = "css/Images/Cat2.jpg"
                 },

                  new Animal()
                  {
                      AnimalId = 3,
                      CategoryId = 1,
                      Name = "Бусинка",
                      Gender = "Female",
                      Age = "1 год",
                      DayOfPublication = DateTime.UtcNow,
                      Contacts = "Georgii 079996377",
                      ImagePath = "css/Images/Cat3.jpg"
                  }
                );
        }
    }
}
