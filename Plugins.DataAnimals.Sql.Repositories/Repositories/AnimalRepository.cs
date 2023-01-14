using AnimalShelter;
using AnimalShelterCore;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataAnimalsPluginInterfaces;


namespace Plugins.DataAnimals.Sql.Repositories.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly AnimalShelterDbContext _animalShelterDbContext;
        

        public AnimalRepository(AnimalShelterDbContext animalShelterDbContext)
        {
            _animalShelterDbContext = animalShelterDbContext;           
        }

        public void AddAnimal(Animal animal)
        {
            try
            {
                _animalShelterDbContext.Animals.Add(animal);
                _animalShelterDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }       
        }

        public void DeleteAnimal(int animalId)
        {
            try
            {
                var animalToDelete = GetAnimalById(animalId);
                if(animalToDelete == null)
                {
                    return;
                }
                _animalShelterDbContext.Animals.Remove(animalToDelete);
                _animalShelterDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Animal> GetAnimalByCategoryId(int categoryId)
        {
            return _animalShelterDbContext.Animals.Where(x => x.CategoryId == categoryId).ToList();
        }

        public Animal GetAnimalById(int id)
        {
            return _animalShelterDbContext.Animals.Find(id);
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return _animalShelterDbContext.Animals.ToList();
        }

       

        public void Update(Animal animal)
        {
            try
            {
                var animalToUpdate = GetAnimalById(animal.AnimalId);
                if(animalToUpdate == null)
                {
                    return;
                }
                animalToUpdate.Name = animal.Name;
                animalToUpdate.Gender = animal.Gender;
                animalToUpdate.Age = animal.Age;
                animalToUpdate.DayOfPublication = animal.DayOfPublication;
                animalToUpdate.Contacts = animal.Contacts;
                animalToUpdate.ImagePath = animal.ImagePath;              
                _animalShelterDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
