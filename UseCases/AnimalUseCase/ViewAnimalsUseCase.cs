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
    public class ViewAnimalsUseCase : IViewAnimalsUseCase
    {
        private readonly IAnimalRepository _animalRepository;

        public ViewAnimalsUseCase(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public IEnumerable<Animal> Execute()
        {
           return _animalRepository.GetAnimals();
        }  
    }
}
