using System;

namespace ArtGallery.DataAccessLayer
{
    public class UnitOfWork : IDisposable, IUnitOfWork
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
        IArtistRepository _artistRepository;
        IWorkRepository _workRepository;
        public IArtistRepository ArtistRepository
        {
            get
            {
                if (_artistRepository == null)
                {
                    _artistRepository = new ArtistRepository(_context);
                }
                return _artistRepository;
            }
        }
        public IWorkRepository WorkRepository
        {
            get
            {
                if (_workRepository == null)
                {
                    _workRepository = new WorkRepository(_context);
                }
                return _workRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
