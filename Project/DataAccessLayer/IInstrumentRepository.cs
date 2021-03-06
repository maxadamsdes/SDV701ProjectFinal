using System.Collections;
using System.Collections.Generic;

namespace InstrumentShop.DataAccessLayer
{
    public interface IInstrumentRepository
    {
        void Add(Instrument instance);
        void Delete(int id);
        void Delete(Instrument instance);
        Instrument Get(int id);
        IEnumerable<Instrument> List();
        IEnumerable ListNames();
        void Update(Instrument instance);
    }
}