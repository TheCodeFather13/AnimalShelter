using AnimalShelter;
using AnimalShelterCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataAnimalsPluginInterfaces
{
    public interface ISectionRepository
    {
        IEnumerable<Section> GetSections();     
        Section GetSection(string sectionId);
        void AddSection(Section section);
        void Update(Section section);
        Section GetSectionById(int id);
        void DeleteSection(int sectionId);       
    }
}
