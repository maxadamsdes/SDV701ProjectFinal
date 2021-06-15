namespace ArtGallery.Models
{
    public class CategoryListItemModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
