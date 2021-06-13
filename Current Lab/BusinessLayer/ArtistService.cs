using ArtGallery.DataAccessLayer;
using AutoMapper;
using System.Collections;
using System.Collections.Generic;

namespace ArtGallery.BusinessLayer
{
    public class ArtistService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ArtistService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int Add(Models.ArtistModel artist)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.ArtistModel, Artist>()
            .ForMember(x => x.Works, opt => opt.Ignore()));
            IMapper mapper = new Mapper(config);
            var data = new Artist();
            mapper.Map(artist, data);
            _unitOfWork.ArtistRepository.Add(data);
            _unitOfWork.Save();
            return data.ID;
        }

        public int Update(Models.ArtistModel artist)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.ArtistModel, Artist>()
            .ForMember(x => x.Works, opt => opt.Ignore()));
            IMapper mapper = new Mapper(config);
            var data = _unitOfWork.ArtistRepository.Get(artist.ID);
            mapper.Map(artist, data);
            _unitOfWork.ArtistRepository.Update(data);
            _unitOfWork.Save();
            return data.ID;
        }

        public void Delete(int id)
        {
            _unitOfWork.ArtistRepository.Delete(id);
            _unitOfWork.Save();
        }
        public IList<Models.ArtistModel> List()
        {
            var artists = _unitOfWork.ArtistRepository.List();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Artist, Models.ArtistModel>();
                cfg.CreateMap<Work, Models.WorkModel>();
            });
            IMapper mapper = new Mapper(config);
            var models = new List<Models.ArtistModel>();
            mapper.Map(artists, models);
            return models;
        }
        public IEnumerable ListNames()
        {
            return _unitOfWork.ArtistRepository.ListNames();
        }


    }
}
