using InstrumentShop.Models;
using System.Collections;
using System.Collections.Generic;

namespace InstrumentShop.BusinessLayer
{
    public interface IInstrumentService
    {
        int Add(InstrumentModel instrument);
        void Delete(int id);
        InstrumentModel Get(int instrumentID);
        IList<InstrumentModel> List();
        IEnumerable ListNames();
        int Update(InstrumentModel instrument);
    }
}