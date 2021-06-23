namespace InstrumentShop.Models
{
    public class OrderListItemModel
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal PriceTotal { get; set; }
        public int Status { get; set; }
    }
}
