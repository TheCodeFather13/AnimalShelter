using AnimalShelter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.AnimalUseCasesInterfaces
{
    public interface IEditAnimalUseCase
    {
       public void Execute(Animal animal);
    }
}
