namespace StudentDataAPI.Models
{
    public class PersonalInformation
    {
        public int IdNumber { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string? Middlename { get; set; }
        public string Address { get; set;}

        public string FundSource { get; set; }
        public string FundSourceType { get; set; }
        public string Job { get; set; }
        public string SalaryEnough { get; set; }
        public string SalaryRange { get; set; }
    }
}
