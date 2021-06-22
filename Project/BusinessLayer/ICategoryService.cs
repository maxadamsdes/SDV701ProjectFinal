using InstrumentShop.Models;
using System.Collections;
using System.Collections.Generic;

namespace InstrumentShop.BusinessLayer
{
    public interface ICategoryService
    {
        int Add(CategoryModel category);
        void Delete(int id);
        CategoryModel Get(int id);
        IList<CategoryModel> List();
        IList<CategoryModel> List(string search, Sort sortBy);
        IEnumerable ListNames();
        int Update(CategoryModel category);
    }
}