using InstrumentShop.Models;
using System.Collections;
using System.Collections.Generic;

namespace InstrumentShop.DataAccessLayer
{
    public interface ICategoryRepository
    {
        void Add(Category instance);
        void Delete(Category instance);
        void Delete(int id);
        Category Get(int id);
        IEnumerable<Category> List();
        IEnumerable ListNames();
        IEnumerable<Category> List(string search, Sort sortBy);
        void Update(Category instance);
    }
}