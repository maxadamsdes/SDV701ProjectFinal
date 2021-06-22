using InstrumentShop.BusinessLayer;
using InstrumentShop.DataAccessLayer;
using System.Collections;
using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using InstrumentShop.Models;
using System;

namespace InstrumentShop.RestApi
{
    public class InstrumentController : System.Web.Http.ApiController
    {
        [HttpGet]
        public IEnumerable ListNames()
        {
            using (var unitOfInstrument = new UnitOfInstrument())
            {
                var service = new InstrumentService(unitOfInstrument);
                return service.ListNames();
            }
        }
        [HttpGet]
        public InstrumentListitemModel Get(int id)
        {
            using (var unitOfInstrument = new UnitOfInstrument())
            {
                var service = new InstrumentService(unitOfInstrument);
                var instrument = from a in service.List()
                             where a.ID.Equals(id)
                             select a;
                return instrument.FirstOrDefault();
            }
        }

        [HttpPost]

        public int Add(InstrumentListitemModel instrument)
        {
            Console.WriteLine("How have we got here then...");
            Validate(instrument);
            if (!ModelState.IsValid)
            {
                throw new ApplicationException();
            }
            using (var unitOfInstrument = new UnitOfInstrument())
            {
                var service = new InstrumentService(unitOfInstrument);
                service.Add(instrument);
                return instrument.ID;
            }
        }

        [HttpPut]
        public int Update(InstrumentListitemModel instrument)
        {
            Validate(instrument);
            if (!ModelState.IsValid)
            {
                //throw new ApplicationException();
            }
            using (var unitOfInstrument = new UnitOfInstrument())
            {
                var service = new InstrumentService(unitOfInstrument);
                service.Update(instrument);
                return instrument.ID;
            }
        }

        [HttpDelete]
        public void Delete(int id)
        {
            using (var unitOfInstrument = new UnitOfInstrument())
            {
                var service = new InstrumentService(unitOfInstrument);
                service.Delete(id);
            }
        }
    }

}
