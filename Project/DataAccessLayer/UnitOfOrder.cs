using System;

namespace InstrumentShop.DataAccessLayer
{
    public class UnitOfOrder : IDisposable, IUnitOfOrder
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
        IOrderRepository _ordersRepository;
        public IOrderRepository OrderRepository
        {
            get
            {
                if (_ordersRepository == null)
                {
                    _ordersRepository = new OrderRepository(_context);
                }
                return _ordersRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
