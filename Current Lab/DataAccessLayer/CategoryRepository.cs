using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Data.Entity;

namespace ArtGallery.DataAccessLayer
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

        public virtual IEnumerable ListNames()
        {
            var query = from category in All
                        select new { category.ID, category.Name };
            return query.ToList();
        }
    }

}
