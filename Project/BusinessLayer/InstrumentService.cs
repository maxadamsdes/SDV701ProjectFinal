using InstrumentShop.DataAccessLayer;
using AutoMapper;
using System.Collections.Generic;
using System.Collections;
using InstrumentShop.Models;

namespace InstrumentShop.BusinessLayer
{
    public class InstrumentService : IInstrumentService
    {
        private readonly IUnitOfInstrument _unitOfInstrument;
        public InstrumentService(IUnitOfInstrument unitOfInstrument)
        {
            _unitOfInstrument = unitOfInstrument;
        }

        public int Add(Models.InstrumentModel instrument)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.InstrumentModel, Instrument>()
            .ForMember(x => x.Category, opt => opt.Ignore()));
            IMapper mapper = new Mapper(config);
            var data = new Instrument();
            mapper.Map(instrument, data);
            _unitOfInstrument.InstrumentRepository.Add(data);
            _unitOfInstrument.Save();
            return data.ID;
        }

        public int Update(InstrumentModel instrument)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.InstrumentModel, Instrument>()
            .ForMember(x => x.Category, opt => opt.Ignore()));
            IMapper mapper = new Mapper(config);
            var data = _unitOfInstrument.InstrumentRepository.Get(instrument.ID);
            mapper.Map(instrument, data);
            _unitOfInstrument.InstrumentRepository.Update(data);
            _unitOfInstrument.Save();
            return data.ID;
        }
        public InstrumentModel Get(int instrumentID)
        {
            var category = _unitOfInstrument.InstrumentRepository.Get(instrumentID);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Instrument, InstrumentModel>();
            });
            IMapper mapper = new Mapper(config);
            var data = new InstrumentModel();
            mapper.Map(category, data);
            return data;
        }

        public void Delete(int id)
        {
            _unitOfInstrument.InstrumentRepository.Delete(id);
            _unitOfInstrument.Save();
        }
        public IList<Models.InstrumentModel> List()
        {
            var instrument = _unitOfInstrument.InstrumentRepository.List();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Instrument, Models.InstrumentModel>();
            });
            IMapper mapper = new Mapper(config);
            var models = new List<Models.InstrumentModel>();
            mapper.Map(instrument, models);
            return models;
        }
        public IEnumerable ListNames()
        {
            return _unitOfInstrument.InstrumentRepository.ListNames();
        }
    }
}
