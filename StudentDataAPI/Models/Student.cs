namespace StudentDataAPI.Models
{
    public class Student
    {
        public PersonalInformation PersonalInformation { get; set; }
        public FamilyProfile FamilyProfile { get; set; }
        public SHSInformation SHSInformation { get; set; }
        public CollegeInformation CollegeInformation { get; set; }

    }
}
