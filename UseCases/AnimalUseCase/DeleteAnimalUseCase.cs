using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.AnimalUseCasesInterfaces;
using UseCases.DataAnimalsPluginInterfaces;

namespace UseCases.AnimalUseCase
{
    public class DeleteAnimalUseCase : IDeleteAnimalUseCase
    {
        private readonly IAnimalRepository _animalRepository;

        public DeleteAnimalUseCase(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public void Delete(int animalId)
        {
            _animalRepository.DeleteAnimal(animalId);
        }
    }
}
