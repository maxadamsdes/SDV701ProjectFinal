using System;

namespace InstrumentShop.Models
{
    public class InstrumentListItemModel
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public decimal PricePerItem { get; set; }
        public DateTime LastModified { get; set; }
        public int QuantityLeft { get; set; }
        public string Condition { get; set; }
        public string Tuning { get; set; }
        public string Mouthpiece { get; set; }
        public string NumberOfStrings { get; set; }
    }
}
