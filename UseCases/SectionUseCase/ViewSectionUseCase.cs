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
    public class ViewSectionUseCase : IViewSectionUseCase
    {
        private readonly ISectionRepository _sectionRepository;

        public ViewSectionUseCase(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }
        public Section GetSection(string sectionId)
        {
            return _sectionRepository.GetSection(sectionId);
        }
    }
}
