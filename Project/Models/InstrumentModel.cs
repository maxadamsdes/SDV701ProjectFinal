using System;
using System.ComponentModel.DataAnnotations;

namespace InstrumentShop.Models
{
    public class InstrumentListitemModel
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
        public string Tuning { get; set; }
        [StringLength(20)]
        public int NumberOfStrings { get; set; }
        [StringLength(20)]
        public string Mouthpiece { get; set; }

    }
}
