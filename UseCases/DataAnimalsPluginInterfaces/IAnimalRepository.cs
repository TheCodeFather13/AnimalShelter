using AnimalShelter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataAnimalsPluginInterfaces
{
    public interface IAnimalRepository
    {
        IEnumerable<Animal> GetAnimals();
        void AddAnimal(Animal animal);
        void Update(Animal animal);
        Animal GetAnimalById(int id);
        void DeleteAnimal(int animalId);
        IEnumerable<Animal> GetAnimalByCategoryId(int categoryId);
    }
}
