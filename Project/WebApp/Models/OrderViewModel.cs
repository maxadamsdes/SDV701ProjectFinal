using InstrumentShop.Models;

namespace WebApp.Models
{
    public class OrderViewModel
    {
        public string Title { get; set; }
        public int Quantity { get; set; }
        public InstrumentModel Instrument { get; set; }
        public OrderModel NewOrder { get; set; }
    }
}