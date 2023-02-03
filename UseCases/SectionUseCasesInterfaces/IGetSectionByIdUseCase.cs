using AnimalShelter;
using AnimalShelterCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.SectionUseCasesInterfaces
{
    public interface IGetSectionByIdUseCase
    {
        Section GetSectionById(int sectionId);
    }
}
