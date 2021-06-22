using InstrumentShop.Models;
using System.Collections;
using System.Collections.Generic;

namespace InstrumentShop.BusinessLayer
{
    public interface IOrderService
    {
        int Add(OrderModel order);
        void Delete(int id);
        IList<OrderModel> List();
        IEnumerable ListNames();
        int Update(OrderModel order);
    }
}