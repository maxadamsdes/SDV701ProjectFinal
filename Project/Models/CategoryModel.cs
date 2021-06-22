using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InstrumentShop.Models
{
    public class CategoryModel
    {
        public int ID { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(25)]
        public string Description { get; set; }
        public IList<InstrumentListitemModel> Instruments { get; set; }
    }
}
