using System.ComponentModel.DataAnnotations;

namespace StudentDataAPI.Models
{
    public class SHSInformation
    {
        public int StudentId { get; set; }
        [StringLength(50)] // Adjust the maximum length as needed
        public string TypeOfSchool { get; set; }

        [StringLength(50)] // Adjust the maximum length as needed
        public string SeniorHighSchool { get; set; }

        [StringLength(100)] // Adjust the maximum length as needed
        public string JoinedScienceHigh { get; set; }

        [StringLength(20)] // Adjust the maximum length as needed
        public string ScienceHighSchool { get; set; }

        [StringLength(5)] // Adjust the maximum length as needed
        public string Strand { get; set; }

        [StringLength(5)] // Adjust the maximum length as needed
        public string WithHonors { get; set; }

        // Other properties...

        [StringLength(50)] // Adjust the maximum length as needed
        public string AcademicExcellenceAward { get; set; }

        [StringLength(5)] // Adjust the maximum length as needed
        public string GradeRangeEnglish { get; set; }

        [StringLength(5)] // Adjust the ma
                          // ximum length as needed
        public string GradeRangeMath { get; set; }

        [StringLength(5)] // Adjust the maximum length as needed
        public string GradeRangeScience { get; set; }

        [StringLength(5)] // Adjust the maximum length as needed
        public string GPA { get; set; }
    }
}
