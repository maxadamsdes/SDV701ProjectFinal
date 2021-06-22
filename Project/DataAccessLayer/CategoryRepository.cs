using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Data.Entity;
using System.Linq.Dynamic.Core;
using InstrumentShop.Models;

namespace InstrumentShop.DataAccessLayer
{
    public class CategoryRepository : Repository, ICategoryRepository
    {
        public CategoryRepository(ModelContext context) : base(context)
        {
        }

        protected virtual IQueryable<Category> All
        {
            get
            {
                return Context.Set<Category>();
            }
        }
        public virtual void Add(Category instance)
        {
            if (instance != null)
            {
                Context.Set<Category>().Add(instance);
            }
        }
        public virtual Category Get(int id)
        {
            return All.FirstOrDefault(a => a.ID == id);
        }
        public virtual void Delete(int id)
        {
            Delete(Get(id));
        }
        public virtual void Delete(Category instance)
        {
            if (instance != null)
            {
                Context.Entry(instance).State = EntityState.Deleted;
            }
        }
        public virtual void Update(Category instance)
        {
            if (instance != null)
            {
                Context.Entry(instance).State = EntityState.Modified;
            }
        }
        public virtual IEnumerable<Category> List()
        {
            return All.ToList();
        }

        public virtual IEnumerable<Category> List(string search, Sort sort)
        {
            //Check if the field is a category property
            if (typeof(Category).GetProperty(sort.Field) == null)
            {
                sort.Field = "Description";
            }

            var query = All;

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(c => c.Description != null && c.Description.ToLower().Contains(search.ToLower()));
            }

            if (sort.Direction == SortOrder.Ascending)
            {
                query = query.OrderBy(sort.Field);
            }
            else
            {
                query = query.OrderBy($"{sort.Field} desc");
            }
            return query.ToList();
        }

        public virtual IEnumerable ListNames()
        {
            var query = from category in All
                        select new { category.ID, category.Description };
            return query.ToList();
        }
    }

}
