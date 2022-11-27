﻿using AnimalShelterCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataAnimalsPluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases.CategoriesUseCases
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetCategoryByIdUseCase(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category Execute(int categoryId)
        {
            return _categoryRepository.GetCategoryById(categoryId);
        }
    }
}
