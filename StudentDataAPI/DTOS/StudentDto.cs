using StudentDataAPI.Models;

namespace StudentDataAPI.DTOS
{
    public class StudentDto
    {
        public PersonalInformationDto PersonalInformation { get; set; }
        public FamilyProfileDto FamilyProfile { get; set; }
        public SHSInformationDto SHSInformation { get; set; }
        public CollegeInformationDto CollegeInformation { get; set; }
    }
}
