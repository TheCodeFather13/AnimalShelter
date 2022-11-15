using AnimalShelter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.AnimalUseCasesInterfaces;
using UseCases.DataAnimalsPluginInterfaces;

namespace UseCases.AnimalUseCase
{
    public class AddAnimalUseCase : IAddAnimalUseCase
    {
        private readonly IAnimalRepository _animalRepository;

        public AddAnimalUseCase(IAnimalRepository animalRepository)
        {
           _animalRepository = animalRepository;
        }

        public void AddAnimal(Animal animal)
        {
           _animalRepository.AddAnimal(animal);
        }
    }
}
