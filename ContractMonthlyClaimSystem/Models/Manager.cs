using System.ComponentModel.DataAnnotations;
using System.Net;

namespace ContractMonthlyClaimSystem.Models
{
    public class Manager:UserActivity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ModuleCode { get; set; }
        public string Detail { get; set; }
    }
}
