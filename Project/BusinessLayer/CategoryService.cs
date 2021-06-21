using InstrumentShop.DataAccessLayer;
using InstrumentShop.Models;
using AutoMapper;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace InstrumentShop.BusinessLayer
{
    public class CategoryService
    {
        private readonly IUnitOfInstrument _unitOfInstrument;
        public CategoryService(IUnitOfInstrument unitOfInstrument)
        {
            _unitOfInstrument = unitOfInstrument;
        }

        public int Add(CategoryModel category)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CategoryModel, Category>()
            .ForMember(x => x.Instruments, opt => opt.Ignore()));
            IMapper mapper = new Mapper(config);
            var data = new Category();
            mapper.Map(category, data);
            _unitOfInstrument.CategoryRepository.Add(data);
            _unitOfInstrument.Save();
            return data.ID;
        }

        public int Update(CategoryModel category)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CategoryModel, Category>()
            .ForMember(x => x.Instruments, opt => opt.Ignore()));
            IMapper mapper = new Mapper(config);
            var data = _unitOfInstrument.CategoryRepository.Get(category.ID);
            mapper.Map(category, data);
            _unitOfInstrument.CategoryRepository.Update(data);
            _unitOfInstrument.Save();
            return data.ID;
        }

        public void Delete(int id)
        {
            _unitOfInstrument.CategoryRepository.Delete(id);
            _unitOfInstrument.Save();
        }
        public IList<CategoryModel> List()
        {
            var categorys = _unitOfInstrument.CategoryRepository.List();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Category, CategoryModel>();
                cfg.CreateMap<Instrument, InstrumentModel>();

            });
            var mapper = config.CreateMapper();


            //IMapper mapper = new Mapper(config);

            var models = new List<CategoryModel>();
            mapper.Map(categorys, models);
            return models;
        }
        public IEnumerable ListNames()
        {
            return _unitOfInstrument.CategoryRepository.ListNames();
        }


    }
}