using System;

namespace InstrumentShop.DataAccessLayer
{
    public class UnitOfInstrument : IDisposable, IUnitOfInstrument
    {
        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing) { _context.Dispose(); }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        ModelContext _context = new ModelContext();
        ICategoryRepository _categoryRepository;
        IInstrumentRepository _instrumentRepository;
        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_context);
                }
                return _categoryRepository;
            }
        }
        public IInstrumentRepository InstrumentRepository
        {
            get
            {
                if (_instrumentRepository == null)
                {
                    _instrumentRepository = new InstrumentRepository(_context);
                }
                return _instrumentRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
