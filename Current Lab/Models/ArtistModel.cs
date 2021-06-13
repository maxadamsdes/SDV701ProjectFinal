using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArtGallery.Models
{
    public class ArtistModel
    {
        public int ID { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(25)]
        public string Name { get; set; }
        [StringLength(20)]
        public string Speciality { get; set; }
        [StringLength(20, MinimumLength = 7)]
        public string Phone { get; set; }
        public IList<WorkModel> Works { get; set; }
    }
}
