using System.ComponentModel.DataAnnotations;

namespace InstrumentShop.Models
{
    public class OrderListItemModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal PriceTotal { get; set; }
    }
}
