using System.ComponentModel.DataAnnotations;

namespace OpenRepairManager.Common.Models
{

    public class RepairItem
    {
        public RepairItem() { }

        public RepairItem(int iD, string itemName, string? partnerProductCategory, string? productCategory, int? productCategoryID, string? brand, int? productYear, float? productAge, string problem, int repairStatus, int sessionID, Guid itemGuid, string customerName)
        {
            ID = iD;
            ItemName = itemName;
            PartnerProductCategory = partnerProductCategory;
            ProductCategory = productCategory;
            ProductCategoryID = productCategoryID;
            Brand = brand;
            ProductYear = productYear;
            ProductAge = productAge;
            Problem = problem;
            RepairStatus = repairStatus;
            Completed = false;
            SessionID = sessionID;
            ItemGuid = itemGuid;
            CustomerName = customerName;
        }

        [Key]
        public int ID { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        [Display(Name = "Product Category")]
        // ORS ID partner_product_category
        public string? PartnerProductCategory { get; set; }

        [Display(Name = "Elecrical Category")]
        //ORS ID produt_category
        public string? ProductCategory { get; set; }

        //ORS ID priduct_category_id
        public int? ProductCategoryID { get; set; }

        public string? Brand { get; set; }

        //ORS ID year_of_manufacture
        public int? ProductYear { get; set; }

        //ORS ID product_age
        [Display (Name = "Age of Item")]
        public float? ProductAge { get; set; }

        [Required]
        public string Problem { get; set; } = "";

        //ORS ID repair_status
        [Display(Name = "Status")]
        public int RepairStatus { get; set; } = 0;

        [Display(Name = "Repair Barrier")]
        //ORS ID repair_barrier_if_end_of_life
        public int? RepairBarrier { get; set; }

        public bool Completed { get; set; }

        public int SessionID { get; set; }
        public Session? Session { get; set; }

        public Guid ItemGuid { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string CustomerName { get; set; }

        public string? ItemNotes { get; set; }

    }
}
