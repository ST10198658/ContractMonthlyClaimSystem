namespace ContractMonthlyClaimSystem.Models
{
    public class ClaimApplication:UserActivity
    {
        public int Id { get; set; }
        public string LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }

        public string FirstNameId { get; set; }
        public Lecturer FirstName { get; set; }

        public string LastNameId { get; set; }
        public Lecturer LastName { get; set; }

        public string ProgrammeNameId { get; set; }
        public Lecturer ProgrammeName { get; set; }

        public Lecturer ModuleCode { get; set; }
        public string ModuleCodeID { get; set; }

        public Lecturer Session { get; set; }
        public int SessionsId { get; set; }

        public Lecturer Group { get; set; }
        public int GroupId { get; set; }

        public Lecturer Rate { get; set; }
        public int RateId { get; set; }

        public string Description {  get; set; }

         public int NumOfDays { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
