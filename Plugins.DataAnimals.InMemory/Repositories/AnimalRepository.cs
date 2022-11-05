using AnimalShelter;
using UseCases.DataAnimalsPluginInterfaces;

namespace Plugins.DataAnimals.InMemory.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        private List<Animal> _animals = new List<Animal>();
        public void AddAnimal(Animal animal)
        {
            try
            {
                if (_animals != null && _animals.Count > 0)
                {
                    var maxAnimalId = _animals.Max(x => x.AnimalId);
                    animal.AnimalId = maxAnimalId + 1;
                }
                else
                {
                    animal.AnimalId = 1;
                }
                _animals.Add(animal);
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
                if (animalToDelete != null)
                {
                    _animals.Remove(animalToDelete);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public IEnumerable<Animal> GetAnimalByCategoryId(int categoryId)
        {
            return _animals.FindAll(x => x.CategoryId == categoryId);
        }

        public Animal GetAnimalById(int id)
        {
            return _animals.Find(x => x.AnimalId == id);
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return _animals;
        }

        public void Update(Animal animal)
        {
            try
            {
                var animalToUpdate = GetAnimalById(animal.AnimalId);
                if (animalToUpdate != null)
                {
                    animalToUpdate.Name = animal.Name;
                    animalToUpdate.CategoryId = animal.CategoryId;
                    animalToUpdate.Gender = animal.Gender;
                    animalToUpdate.Age = animal.Age;
                    animalToUpdate.DayOfPublication = animal.DayOfPublication;
                    animalToUpdate.Contacts = animal.Contacts;
                    animalToUpdate.ImagePath = animal.ImagePath;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}