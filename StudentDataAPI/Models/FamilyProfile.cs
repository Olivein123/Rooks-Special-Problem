namespace StudentDataAPI.Models
{
    public class FamilyProfile
    {
        public int StudentId { get; set; }
        public string MotherOccupation { get; set; }
        public string FatherOccupation { get; set; }
        public int TotalIncome { get; set;}
        public int TotalSiblings { get; set; }
        public int ParentDependentSiblings { get; set; }
        public int GraduatedSiblings { get; set; }
    }
}
