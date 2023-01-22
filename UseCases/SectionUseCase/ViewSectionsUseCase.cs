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
    public class ViewSectionsUseCase : IViewSectionsUseCase
    {
        private readonly ISectionRepository _sectionRepository;

        public ViewSectionsUseCase(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }
        public IEnumerable<Section> Execute()
        {
            return _sectionRepository.GetSections();
        }
    }
}
