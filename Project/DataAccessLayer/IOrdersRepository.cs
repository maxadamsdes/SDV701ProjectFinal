using System.Collections;
using System.Collections.Generic;

namespace InstrumentShop.DataAccessLayer
{
    public interface IOrderRepository
    {
        void Add(Order instance);
        void Delete(Order instance);
        void Delete(int id);
        Order Get(int id);
        IEnumerable<Order> List();
        IEnumerable ListNames();
        void Update(Order instance);
    }
}