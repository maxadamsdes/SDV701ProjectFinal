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
        IOrderRepository _orderRepository;
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
        public IOrderRepository OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new OrderRepository(_context);
                }
                return _orderRepository;
            }
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        Console.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
        }
    }
}
