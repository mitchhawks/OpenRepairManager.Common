using System.ComponentModel.DataAnnotations;

namespace OpenRepairManager.Common.Models
{
    public class ApiKey
    {
        [Key]
        public string Key { get; set; }

        public string ApplicationUserID { get; set; }
    }
}
