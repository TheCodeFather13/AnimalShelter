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
    public class EditSectionUseCase : IEditSectionUseCase
    {
        private readonly ISectionRepository _sectionRepository;

        public EditSectionUseCase(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }
        public void Execute(Section section)
        {
            _sectionRepository.Update(section);
        }
    }
}
