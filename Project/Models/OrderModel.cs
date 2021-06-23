using System.ComponentModel.DataAnnotations;

namespace InstrumentShop.Models
{
    public class OrderModel
    {
        public int ID { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public int ItemID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal? PriceTotal { get; set; }
        public int Status { get; set; }
    }
}
