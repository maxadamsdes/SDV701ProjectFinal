using System.Collections.Generic;

namespace ArtGallery.DataAccessLayer
{
    public interface IWorkRepository
    {
        void Add(Work instance);
        void Delete(int id);
        void Delete(Work instance);
        Work Get(int id);
        IEnumerable<Work> List();
        void Update(Work instance);
    }
}