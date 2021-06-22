using InstrumentShop.DataAccessLayer;
using AutoMapper;
using System.Collections.Generic;
using System.Collections;

namespace InstrumentShop.BusinessLayer
{
    public class InstrumentService
    {
        private readonly IUnitOfInstrument _unitOfInstrument;
        public InstrumentService(IUnitOfInstrument unitOfInstrument)
        {
            _unitOfInstrument = unitOfInstrument;
        }

        public int Add(Models.InstrumentListitemModel instrument)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.InstrumentListitemModel, Instrument>()
            .ForMember(x => x.Category, opt => opt.Ignore()));
            IMapper mapper = new Mapper(config);
            var data = new Instrument();
            mapper.Map(instrument, data);
            _unitOfInstrument.InstrumentRepository.Add(data);
            _unitOfInstrument.Save();
            return data.ID;
        }

        public int Update(Models.InstrumentListitemModel instrument)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.InstrumentListitemModel, Instrument>()
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
        public IList<Models.InstrumentListitemModel> List()
        {
            var instrument = _unitOfInstrument.InstrumentRepository.List();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Instrument, Models.InstrumentListitemModel>();
                cfg.CreateMap<Instrument, Models.InstrumentListitemModel>();
            });
            IMapper mapper = new Mapper(config);
            var models = new List<Models.InstrumentListitemModel>();
            mapper.Map(instrument, models);
            return models;
        }
        public IEnumerable ListNames()
        {
            return _unitOfInstrument.InstrumentRepository.ListNames();
        }


    }
}
