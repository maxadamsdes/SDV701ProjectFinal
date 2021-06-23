using InstrumentShop.DataAccessLayer;
using InstrumentShop.Models;
using AutoMapper;
using System.Collections;
using System.Collections.Generic;

namespace InstrumentShop.BusinessLayer
{
    public class CategoryService : ICategoryService
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

        public CategoryModel Get(int categoryID)
        {
            var category = _unitOfInstrument.CategoryRepository.Get(categoryID);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Category, CategoryModel>();
                cfg.CreateMap<Instrument, InstrumentModel>();
            });
            IMapper mapper = new Mapper(config);
            var data = new CategoryModel();
            mapper.Map(category, data);
            return data;
        }

        public IList<CategoryModel> List()
        {
            var categorys = _unitOfInstrument.CategoryRepository.List();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Category, CategoryModel>();
                cfg.CreateMap<Instrument, InstrumentModel>();

            });
            IMapper mapper = new Mapper(config);
            var models = new List<CategoryModel>();
            mapper.Map(categorys, models);
            return models;
        }
        public IList<CategoryModel> List(string search, Sort sortBy)
        {
            var categorys = _unitOfInstrument.CategoryRepository.List(search, sortBy);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Category, CategoryModel>();
                cfg.CreateMap<Instrument, InstrumentModel>();

            });
            IMapper mapper = new Mapper(config);
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