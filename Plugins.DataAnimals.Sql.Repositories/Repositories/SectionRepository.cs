using AnimalShelterCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataAnimalsPluginInterfaces;

namespace Plugins.DataAnimals.Sql.Repositories.Repositories
{
    public class SectionRepository : ISectionRepository
    {
        private readonly AnimalShelterDbContext _animalShelterDbContext;

        public SectionRepository(AnimalShelterDbContext animalShelterDbContext)
        {
            _animalShelterDbContext = animalShelterDbContext;
        }


        public void AddSection(Section section)
        {
            try
            {
                _animalShelterDbContext.Add(section);
                _animalShelterDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteSection(int sectionId)
        {
            try
            {
                var sectionToDelete = GetSectionById(sectionId);
                if(sectionToDelete == null) 
                {
                    return;
                }
                _animalShelterDbContext.Sections.Remove(sectionToDelete);
                _animalShelterDbContext.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Section GetSectionById(int id)
        {
            return _animalShelterDbContext.Sections.Find(id);
        }

        public IEnumerable<Section> GetSections()
        {
            return _animalShelterDbContext.Sections.ToList();
        }

        public void Update(Section section)
        {
            try
            {
                var sectionToUpdate = GetSectionById(section.SectionId);
                if(sectionToUpdate == null)
                {
                    return;
                }
                sectionToUpdate.Title = section.Title;
                sectionToUpdate.PublicDate = DateTime.Now;
                sectionToUpdate.MainText = section.MainText;
                sectionToUpdate.ImagePath = section.ImagePath;
                _animalShelterDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
