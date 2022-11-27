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
    public class EditAnimalUseCase : IEditAnimalUseCase
    {
        private readonly IAnimalRepository _animalRepository;

        public EditAnimalUseCase(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public void Execute(Animal animal)
        {
            _animalRepository.Update(animal);
        }
    }
}
