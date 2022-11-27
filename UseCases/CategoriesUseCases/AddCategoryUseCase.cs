using AnimalShelterCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataAnimalsPluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases.CategoriesUseCases
{
    public class AddCategoryUseCase : IAddCategoryUseCase
    {
        private ICategoryRepository _categoryRepository;

        public AddCategoryUseCase(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Execute(Category category)
        {
            _categoryRepository.AddCategory(category);
        }
    }
}
