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
    public class OrderController : System.Web.Http.ApiController
    {
        [HttpGet]
        public IEnumerable ListNames()
        {
            using (var unitOfInstrument = new UnitOfInstrument())
            {
                var service = new OrderService(unitOfInstrument);
                return service.ListNames();
            }
        }


        [HttpGet]
        public IEnumerable<OrderModel> List()
        {
            using (var unitOfOrder = new UnitOfInstrument())
            {
                var service = new OrderService(unitOfOrder);
                return service.List();
            }
        }

        [HttpGet]
        public OrderModel Get(int id)
        {
            using (var unitOfOrder = new UnitOfInstrument())
            {
                var service = new OrderService(unitOfOrder);
                var order = from a in service.List()
                             where a.ID.Equals(id)
                             select a;
                return order.FirstOrDefault();
            }
        }

        [HttpPost]

        public int Add(OrderModel order)
        {
            Validate(order);
            if (!ModelState.IsValid)
            {
                throw new ApplicationException();
            }
            using (var unitOfOrder = new UnitOfInstrument())
            {
                var service = new OrderService(unitOfOrder);
                service.Add(order);
                return order.ID;
            }
        }

        [HttpPut]
        public int Update(OrderModel category)
        {
            Validate(category);
            if (!ModelState.IsValid)
            {
                //throw new ApplicationException();
            }
            using (var unitOfOrder = new UnitOfInstrument())
            {
                var service = new OrderService(unitOfOrder);
                service.Update(category);
                return category.ID;
            }
        }

        [HttpDelete]
        public void Delete(int id)
        {
            using (var unitOfOrder = new UnitOfInstrument())
            {
                var service = new OrderService(unitOfOrder);
                service.Delete(id);
            }
        }
    }

}
