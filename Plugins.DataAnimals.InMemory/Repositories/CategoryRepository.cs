using AnimalShelterCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataAnimalsPluginInterfaces;

namespace Plugins.DataAnimals.InMemory.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private List<Category> _categories = new List<Category>();

        public CategoryRepository()
        {
            _categories.Add(new Category()
            {
                CategoryId = 1,
                Name = "Cats"            
            });

            _categories.Add(new Category()
            {
                CategoryId = 2,
                Name = "Dogs"
            });
        }

        public void AddCategory(Category category)
        {
            try
            {
                if(_categories != null && _categories.Count > 0)
                {
                    var maxCategoryId = _categories.Max(x => x.CategoryId);
                    category.CategoryId = maxCategoryId + 1;
                }
                else
                {
                    category.CategoryId = 1;
                }
                _categories?.Add(category);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteCategory(int categoryId)
        {
            _categories.Remove(GetCategoryById(categoryId));
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return _categories.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public void UpdateCategory(Category category)
        {
            try
            {
                var categoryToUpdate = GetCategoryById(category.CategoryId);
                if(categoryToUpdate != null)
                {
                    categoryToUpdate = category;
                }
                else
                {
                    _categories.Add(category);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
