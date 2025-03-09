using System.ComponentModel.DataAnnotations;

namespace OpenRepairManager.Common.Models
{
    public class Test
    {
        [Key]
        public int CatID { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Category Name")]
        public string CatName { get; set; }
    }
}
