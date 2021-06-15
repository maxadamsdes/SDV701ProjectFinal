using System;
using System.ComponentModel.DataAnnotations;

namespace InstrumentShop.Models
{
    public class InstrumentModel
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        [Required]
        [StringLength(25)]
        public string Description { get; set; }
        [Required]
        [Range(0, 10000)]
        public decimal PricePerItem { get; set; }
        [Required]
        public DateTime LastModified { get; set; }
        [Range(0, 1000)]
        public int QuantityLeft { get; set; }
        [Required]
        [StringLength(10)]
        public string Condition { get; set; }
        [StringLength(20)]
        public string Manufacturer { get; set; }
        [StringLength(20)]
        public string Reed { get; set; }
        [StringLength(20)]
        public string NumberOfStrings { get; set; }
        public char InstrumentType { get; set; }
        public static InstrumentModel NewInstrument(char type)
        {
            return new InstrumentModel()
            {
                InstrumentType = Char.ToUpper(type),
                LastModified = DateTime.Now
            };
        }
        public override string ToString()
        {
            return ID + "\t" + LastModified.ToShortDateString();
        }

    }
}
