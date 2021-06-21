using InstrumentShop.DataAccessLayer;
using AutoMapper;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace InstrumentShop.BusinessLayer
{
    public class OrderService
    {
        private readonly IUnitOfOrder _unitOfOrder;
        public OrderService(IUnitOfOrder unitOfOrder)
        {
            _unitOfOrder = unitOfOrder;
        }
        public int Add(Models.OrderModel order)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.OrderModel, Order>());
            IMapper mapper = new Mapper(config);
            var data = new Order();
            mapper.Map(order, data);
            _unitOfOrder.OrderRepository.Add(data);
            _unitOfOrder.Save();
            return data.ID;
        }

        public int Update(Models.OrderModel order)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.OrderModel, Order>()
            .ForMember(x => x, opt => opt.Ignore()));
            IMapper mapper = new Mapper(config);
            var data = _unitOfOrder.OrderRepository.Get(order.ID);
            mapper.Map(order, data);
            _unitOfOrder.OrderRepository.Update(data);
            _unitOfOrder.Save();
            return data.ID;
        }

        public void Delete(int id)
        {
            _unitOfOrder.OrderRepository.Delete(id);
            _unitOfOrder.Save();
        }
        public IList<Models.OrderModel> List()
        {
            var categorys = _unitOfOrder.OrderRepository.List();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Order, Models.OrderModel>();
            });
            var mapper = config.CreateMapper();
            var models = new List<Models.OrderModel>();
            mapper.Map(categorys, models);
            return models;
        }
        public IEnumerable ListNames()
        {
            return _unitOfOrder.OrderRepository.ListNames();
        }


    }
}