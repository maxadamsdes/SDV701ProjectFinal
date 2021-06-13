using ArtGallery.DataAccessLayer;
using AutoMapper;
using System.Collections.Generic;

namespace ArtGallery.BusinessLayer
{
    public class WorkService
    {
        private readonly IUnitOfWork _unitOfWork;
        public WorkService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int Add(Models.WorkModel work)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.WorkModel, Work>()
            .ForMember(x => x.Artist, opt => opt.Ignore()));
            IMapper mapper = new Mapper(config);
            var data = new Work();
            mapper.Map(work, data);
            _unitOfWork.WorkRepository.Add(data);
            _unitOfWork.Save();
            return data.ID;
        }

        public int Update(Models.WorkModel work)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.WorkModel, Work>()
            .ForMember(x => x.Artist, opt => opt.Ignore()));
            IMapper mapper = new Mapper(config);
            var data = _unitOfWork.WorkRepository.Get(work.ID);
            mapper.Map(work, data);
            _unitOfWork.WorkRepository.Update(data);
            _unitOfWork.Save();
            return data.ID;
        }

        public void Delete(int id)
        {
            _unitOfWork.WorkRepository.Delete(id);
            _unitOfWork.Save();
        }
        public IList<Models.WorkModel> List()
        {
            var work = _unitOfWork.WorkRepository.List();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Work, Models.WorkModel>();
                cfg.CreateMap<Work, Models.WorkModel>();
            });
            IMapper mapper = new Mapper(config);
            var models = new List<Models.WorkModel>();
            mapper.Map(work, models);
            return models;
        }


    }
}
