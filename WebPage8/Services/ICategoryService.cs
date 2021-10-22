using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Models;
using WebPage8.ViewModels;

namespace WebPage8.Services
{
    public interface ICategoryService
    {
        Category Add(CreateCategoryViewModel person);
        CategoryViewModel All();
        CategoryViewModel FindBy(CategoryViewModel search);
        Category FindBy(int id);
        Category Edit(int id, Category person);
        bool Remove(int id);
    }
}
