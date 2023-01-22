using AnimalShelterCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataAnimalsPluginInterfaces;
using UseCases.SectionUseCasesInterfaces;

namespace UseCases.SectionUseCase
{
    public class GetSectionByIdUseCase : IGetSectionByIdUseCase
    {
        private readonly ISectionRepository _sectionRepository;

        public GetSectionByIdUseCase(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }
        public Section GetAnimalById(int sectionId)
        {
            return _sectionRepository.GetSectionById(sectionId);
        }
    }
}
