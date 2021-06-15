using System;
using System.ComponentModel.DataAnnotations;

namespace ArtGallery.Models
{
    public class InstrumentModel
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [Range(0, 1000)]
        public decimal Value { get; set; }
        public float? Width { get; set; }
        public float? Height { get; set; }
        [StringLength(15)]
        public string Type { get; set; }
        public float? Weight { get; set; }
        [StringLength(15)]
        public string Material { get; set; }
        public char InstrumentType { get; set; }
        public static InstrumentModel NewInstrument(char type)
        {
            return new InstrumentModel()
            {
                InstrumentType = Char.ToUpper(type),
                Date = DateTime.Now
            };
        }
        public override string ToString()
        {
            return Name + "\t" + Date.ToShortDateString();
        }

    }
}
