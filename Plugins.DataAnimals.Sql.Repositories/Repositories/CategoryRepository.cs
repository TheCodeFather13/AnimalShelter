using AnimalShelterCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataAnimalsPluginInterfaces;

namespace Plugins.DataAnimals.Sql.Repositories.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AnimalShelterDbContext _animalShelterDbContext;

        public CategoryRepository(AnimalShelterDbContext animalShelterDbContext)
        {
            _animalShelterDbContext = animalShelterDbContext;
        }

        public void AddCategory(Category category)
        {
            _animalShelterDbContext.Categories.Add(category);
            _animalShelterDbContext.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            try
            {
                var categoryToDelete = GetCategoryById(categoryId);
                if(categoryToDelete == null)
                {
                    return;
                }
                _animalShelterDbContext.Categories.Remove(categoryToDelete);
                _animalShelterDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return _animalShelterDbContext.Categories.ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _animalShelterDbContext.Categories.Find(categoryId);
        }

        public void UpdateCategory(Category category)
        {
            try
            {
                var categoryToUpdate = GetCategoryById(category.CategoryId);
                if(categoryToUpdate == null)
                {
                    return;
                }
                categoryToUpdate.Name = category.Name;
                _animalShelterDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
