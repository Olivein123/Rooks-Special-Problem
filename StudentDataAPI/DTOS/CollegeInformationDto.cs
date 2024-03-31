namespace StudentDataAPI.DTOS
{
    public class CollegeInformationDto
    {
        public string? Course { get; set; }
        public string? YearLevel { get; set; }
        public int Prog1MidtermGrade { get; set; }
        public string? ExpectedProg1Grade { get; set; }
        public string? Prog1Professor { get; set; }
        public string? ModeOfDelivery { get; set; }
        public string? HasScholarship { get; set; }
        public string? ScholarshipType { get; set; }
        public string? HasExperience { get; set; }
        public string? ProgrammingLanguages { get; set; }
        public string? HasDevice { get; set; }
        public string? IsInCebu { get; set; }
        public string? CurrentPlace { get; set; }
        public string? HasRoom { get; set; }
        public string? HasEnoughSpace { get; set; }
        public string? ModeOfTransportationToSchool { get; set; }
        public string? CommuteCountToSchool { get; set; }
        public string? CommuteDurationToSchool { get; set; }
        public string? ArriveSchoolFeeling { get; set; }
        public string? ModeOfTransportationHome { get; set; }
        public string? CommuteCountToHome { get; set; }
        public string? CommuteDurationToHome { get; set; }
        public string? ArriveHomeFeeling { get; set; }
        public string? PursueCourseReason { get; set; }
    }
}
