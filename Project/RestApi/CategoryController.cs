using InstrumentShop.BusinessLayer;
using InstrumentShop.DataAccessLayer;
using System.Collections;
using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using InstrumentShop.Models;
using System;

namespace InstrumentShop.RestApi
{
    public class CategoryController : System.Web.Http.ApiController
    {
        [HttpGet]
        public IEnumerable ListNames()
        {
            using (var unitOfInstrument = new UnitOfInstrument())
            {
                var service = new CategoryService(unitOfInstrument);
                return service.ListNames();
            }
        }


        [HttpGet]
        public IEnumerable<CategoryModel> List()
        {
            using (var unitOfInstrument = new UnitOfInstrument())
            {
                var service = new CategoryService(unitOfInstrument);
                return service.List();
            }
        }

        [HttpGet]
        public CategoryModel Get(int id)
        {
            using (var unitOfInstrument = new UnitOfInstrument())
            {
                var service = new CategoryService(unitOfInstrument);
                var category = from a in service.List()
                             where a.ID.Equals(id)
                             select a;
                return category.FirstOrDefault();
            }
        }

        [HttpPost]

        public int Add(CategoryModel category)
        {
            Validate(category);
            if (!ModelState.IsValid)
            {
                throw new ApplicationException();
            }
            using (var unitOfInstrument = new UnitOfInstrument())
            {
                var service = new CategoryService(unitOfInstrument);
                service.Add(category);
                return category.ID;
            }
        }

        [HttpPut]
        public int Update(CategoryModel category)
        {
            Validate(category);
            if (!ModelState.IsValid)
            {
                throw new ApplicationException();
            }
            using (var unitOfInstrument = new UnitOfInstrument())
            {
                var service = new CategoryService(unitOfInstrument);
                service.Update(category);
                return category.ID;
            }
        }

        [HttpDelete]
        public void Delete(int id)
        {
            using (var unitOfInstrument = new UnitOfInstrument())
            {
                var service = new CategoryService(unitOfInstrument);
                service.Delete(id);
            }
        }
    }

}
