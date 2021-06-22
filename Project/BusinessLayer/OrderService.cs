using InstrumentShop.DataAccessLayer;
using AutoMapper;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace InstrumentShop.BusinessLayer
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfInstrument _unitOfInstrument;
        public OrderService(IUnitOfInstrument unitOfInstrument)
        {
            _unitOfInstrument = unitOfInstrument;
        }
        public int Add(Models.OrderModel order)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.OrderModel, Order>());
            IMapper mapper = new Mapper(config);
            var data = new Order();
            mapper.Map(order, data);
            _unitOfInstrument.OrderRepository.Add(data);
            _unitOfInstrument.Save();
            return data.ID;
        }

        public int Update(Models.OrderModel order)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.OrderModel, Order>()
            .ForMember(x => x, opt => opt.Ignore()));
            IMapper mapper = new Mapper(config);
            var data = _unitOfInstrument.OrderRepository.Get(order.ID);
            mapper.Map(order, data);
            _unitOfInstrument.OrderRepository.Update(data);
            _unitOfInstrument.Save();
            return data.ID;
        }

        public void Delete(int id)
        {
            _unitOfInstrument.OrderRepository.Delete(id);
            _unitOfInstrument.Save();
        }
        public IList<Models.OrderModel> List()
        {
            var categorys = _unitOfInstrument.OrderRepository.List();
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
            return _unitOfInstrument.OrderRepository.ListNames();
        }


    }
}