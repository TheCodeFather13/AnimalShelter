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
    public class AddSectionUseCase : IAddSectionUseCase
    {
        private readonly ISectionRepository _sectionRepository;

        public AddSectionUseCase(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }
        public void AddSection(Section section)
        {
            _sectionRepository.AddSection(section);
        }
    }
}
