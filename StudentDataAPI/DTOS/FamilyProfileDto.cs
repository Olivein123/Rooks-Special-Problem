namespace StudentDataAPI.DTOS
{
    public class FamilyProfileDto
    {
        public string MotherOccupation { get; set; }
        public string FatherOccupation { get; set; }
        public string TotalIncome { get; set; }
        public int TotalSiblings { get; set; }
        public int ParentDependentSiblings { get; set; }
        public int GraduatedSiblings { get; set; }
    }
}
