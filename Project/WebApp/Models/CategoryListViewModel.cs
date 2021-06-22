using InstrumentShop.Models;
using System.Collections.Generic;

namespace WebApp.Models
{
    public class CategoryListViewModel
    {
        public string Title { get; set; }
        public string Search { get; set; }
        public string Sort { get; set; }
        public string Description { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
    }
}