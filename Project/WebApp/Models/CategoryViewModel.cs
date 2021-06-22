using InstrumentShop.Models;

namespace WebApp.Models
{
    public class CategoryViewModel
    {
        public string Title { get; set; }
        public string Order { get; set; }
        public CategoryModel Category { get; set; }
    }
}