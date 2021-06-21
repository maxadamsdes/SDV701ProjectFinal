using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Data.Entity;

namespace InstrumentShop.DataAccessLayer
{
    public class OrderRepository : Repository, IOrderRepository
    {
        public OrderRepository(ModelContext context) : base(context)
        {
        }

        protected virtual IQueryable<Order> All
        {
            get
            {
                return Context.Set<Order>();
            }
        }
        public virtual void Add(Order instance)
        {
            if (instance != null)
            {
                Context.Set<Order>().Add(instance);
            }
        }
        public virtual Order Get(int id)
        {
            return All.FirstOrDefault(a => a.ID == id);
        }
        public virtual void Delete(int id)
        {
            Delete(Get(id));
        }
        public virtual void Delete(Order instance)
        {
            if (instance != null)
            {
                Context.Entry(instance).State = EntityState.Deleted;
            }
        }
        public virtual void Update(Order instance)
        {
            if (instance != null)
            {
                Context.Entry(instance).State = EntityState.Modified;
            }
        }
        public virtual IEnumerable<Order> List()
        {
            return All.ToList();
        }

        public virtual IEnumerable ListNames()
        {
            var query = from order in All
                        select new { order.ID, order.ItemID, order.Quantity, order.PriceTotal };
            return query.ToList();
        }
    }

}
