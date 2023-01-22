using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataAnimalsPluginInterfaces;
using UseCases.SectionUseCasesInterfaces;

namespace UseCases.SectionUseCase
{
    public class DeleteSectionUseCase : IDeleteSectionUseCase
    {
        private readonly ISectionRepository _sectionRepository;

        public DeleteSectionUseCase(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }
        public void Delete(int sectionId)
        {
            _sectionRepository.DeleteSection(sectionId);
        }
    }
}
