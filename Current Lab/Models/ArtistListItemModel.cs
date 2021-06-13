namespace ArtGallery.Models
{
    public class ArtistListItemModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
