using System.ComponentModel.DataAnnotations;

namespace ContractMonthlyClaimSystem.Models
{
    public class Coordinator:UserActivity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ModuleCode { get; set; }
        public string Detail { get; set; }
    }
}
