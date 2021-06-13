namespace ArtGallery.WinForm
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();
        static Singleton()
        {
        }
        private Singleton()
        {
        }
        public static Singleton Instance => _instance;

    }
}
