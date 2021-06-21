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
        public InstrumentModel Get(int id)
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

        public int Add(InstrumentModel instrument)
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
        public int Update(InstrumentModel instrument)
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
