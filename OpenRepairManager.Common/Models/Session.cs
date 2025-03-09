using System.ComponentModel.DataAnnotations;

namespace OpenRepairManager.Common.Models
{
    public class Session
    {
        [Key]
        public int SessionID { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Session Name")]
        public string SessionName { get; set; }

        [Required(ErrorMessage = "Session description is required")]
        [Display(Name = "Short Description")]
        [StringLength(240)]
        public string SessionInfo { get; set; }

        [Required(ErrorMessage = "Slug is required")]
        [Display(Name = "Url Slug")]
        [StringLength(150)]
        [RegularExpression("^[a-z0-9-]+$", ErrorMessage = "Slug format not valid.")]
        public string SessionSlug { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [Display(Name = "Session Date")]
        [DataType(DataType.Date)]
        public DateTime SessionDate { get; set; } = DateTime.UtcNow.Date;

        [Required(ErrorMessage = "Start Time is required")]
        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "End Time is required")]
        [Display(Name = "End Time")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

        [Display(Name = "Location")]
        public int LocationID { get; set; }

        public Location? Location { get; set; }
    }
}
