namespace StudentDataAPI.Models
{
    public class SHSInformation
    {
        public int StudentId { get; set; }
        public string ? TypeOfSchool { get; set;}
        public string ? SeniorHighSchool { get; set; }
        public string? JoinedScienceHigh { get; set; }
        public string? ScienceHighSchool { get; set; }
        public string ? Strand { get; set; }
        public string ? WithHonors { get; set; }
        public string ? TopNotcher { get; set; }
        public string ? AcademicRank { get; set; }
        public string ? AcademicExcellenceAward { get; set; }
        public string ? GradeRangeEnglish { get; set; }
        public string ? GradeRangeMath { get; set; }
        public string ? GradeRangeScience { get; set; }
        public double GPA { get; set; }
    }
}
