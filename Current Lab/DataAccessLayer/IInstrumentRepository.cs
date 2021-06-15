using System.Collections.Generic;

namespace ArtGallery.DataAccessLayer
{
    public interface IInstrumentRepository
    {
        void Add(Instrument instance);
        void Delete(int id);
        void Delete(Instrument instance);
        Instrument Get(int id);
        IEnumerable<Instrument> List();
        void Update(Instrument instance);
    }
}