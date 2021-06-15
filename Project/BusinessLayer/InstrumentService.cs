using InstrumentShop.DataAccessLayer;
using AutoMapper;
using System.Collections.Generic;

namespace InstrumentShop.BusinessLayer
{
    public class InstrumentService
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

        public int Update(Models.InstrumentModel instrument)
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
                cfg.CreateMap<Instrument, Models.InstrumentModel>();
            });
            IMapper mapper = new Mapper(config);
            var models = new List<Models.InstrumentModel>();
            mapper.Map(instrument, models);
            return models;
        }


    }
}
