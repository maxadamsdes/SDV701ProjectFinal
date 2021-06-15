using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ArtGallery.DataAccessLayer
{
    public class InstrumentRepository : Repository, IInstrumentRepository
    {
        public InstrumentRepository(ModelContext context) : base(context)
        {
        }
        protected virtual IQueryable<Instrument> All
        {
            get
            {
                return Context.Set<Instrument>();
            }
        }
        public virtual void Add(Instrument instance)
        {
            if (instance != null)
            {
                Context.Set<Instrument>().Add(instance);
            }
        }
        public virtual Instrument Get(int id)
        {
            return All.FirstOrDefault(a => a.ID == id);
        }
        public virtual void Delete(int id)
        {
            Delete(Get(id));
        }
        public virtual void Delete(Instrument instance)
        {
            if (instance != null)
            {
                Context.Entry(instance).State = EntityState.Deleted;
            }
        }
        public virtual void Update(Instrument instance)
        {
            if (instance != null)
            {
                Context.Entry(instance).State = EntityState.Modified;
            }
        }
        public virtual IEnumerable<Instrument> List()
        {
            return All.ToList();
        }
    }
}


