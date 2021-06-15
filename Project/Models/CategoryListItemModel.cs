namespace InstrumentShop.Models
{
    public class CategoryListItemModel
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return Description;
        }
    }
}
