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
    public class GetAnimalByIdUseCase : IGetAnimalByIdUseCase
    {
        private readonly IAnimalRepository _animalRepository;

        public GetAnimalByIdUseCase(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }


        public Animal GetAnimalById(int animalId)
        {
            return _animalRepository.GetAnimalById(animalId);
        }
    }
}
