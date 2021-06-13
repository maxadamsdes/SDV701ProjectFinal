using ArtGallery.BusinessLayer;
using ArtGallery.DataAccessLayer;
using System.Collections;
using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using ArtGallery.Models;
using System;

namespace ArtGallery.RestApi
{
    public class ArtistController : System.Web.Http.ApiController
    {
        [HttpGet]
        public IEnumerable ListNames()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var service = new ArtistService(unitOfWork);
                return service.ListNames();
            }
        }


        [HttpGet]
        public IEnumerable<ArtistModel> List()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var service = new ArtistService(unitOfWork);
                return service.List();
            }
        }

        [HttpGet]
        public ArtistModel Get(int id)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var service = new ArtistService(unitOfWork);
                var artist = from a in service.List()
                             where a.ID.Equals(id)
                             select a;
                return artist.FirstOrDefault();
            }
        }

        [HttpPost]

        public int Add(ArtistModel artist)
        {
            Validate(artist);
            if (!ModelState.IsValid)
            {
                throw new ApplicationException();
            }
            using (var unitOfWork = new UnitOfWork())
            {
                var service = new ArtistService(unitOfWork);
                service.Add(artist);
                return artist.ID;
            }
        }

        [HttpPut]
        public int Update(ArtistModel artist)
        {
            Validate(artist);
            if (!ModelState.IsValid)
            {
                throw new ApplicationException();
            }
            using (var unitOfWork = new UnitOfWork())
            {
                var service = new ArtistService(unitOfWork);
                service.Update(artist);
                return artist.ID;
            }
        }

        [HttpDelete]
        public void Delete(int id)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var service = new ArtistService(unitOfWork);
                service.Delete(id);
            }
        }
    }

}
