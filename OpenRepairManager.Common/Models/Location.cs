using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OpenRepairManager.Common.Models
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string LocationName { get; set; }
        [Required]
        [Display(Name = "Street No")]
        public string LocationStreetNo { get; set; }

        [Required]
        [Display(Name = "Street")]
        public string LocationStreetName { get; set; }

        [Required]
        [Display(Name = "Suburb")]
        public string LocationSuburb { get; set; }

        [Required]
        [Display(Name = "Postcode")]
        public string LocationPostCode { get; set; }

        public string GMapsPlaceId { get; set; }
        
        [JsonIgnore]
        public List<Session>? Sessions { get; set; }
    }
}
