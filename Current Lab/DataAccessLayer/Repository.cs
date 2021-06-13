namespace ArtGallery.DataAccessLayer
{
    public abstract class Repository
    {
        public Repository(ModelContext context)
        {
            Context = context;
        }
        protected ModelContext Context { get; private set; }
    }

}
