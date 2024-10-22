namespace ContractMonthlyClaimSystem.Models
{
    public class Claim:UserActivity
    {
        public int Id { get; set; }
        public string ModuleCode { get; set; }
        public string Description { get; set; }
    }
}
