namespace ContractMonthlyClaimSystem.Models
{
    public class Lecturer:UserActivity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public string Email { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string ProgrammeName {get; set;}
        public string ModuleCode { get; set;}
        public DateTime Date { get; set; }
        public int Session { get; set; }
        public int Group { get; set; }
        public int Rate { get; set; }



    }
}
