namespace StudentDataAPI.Services.StudentServices
{
    public interface ISHSInformationService
    {
        Task<IEnumerable<string>> GetTypeOfSchool();
        Task<IEnumerable<string>> GetJoinedScienceHigh();
        Task<IEnumerable<string>> GetScienceHighSchool();
        Task<IEnumerable<string>> GetSeniorHighSchool();
        Task<IEnumerable<string>> GetStrand();
        Task<IEnumerable<string>> GetWithHonors();
        Task<IEnumerable<string>> GetInTopTen();
        Task<IEnumerable<string>> GetAcademicRank();
        Task<IEnumerable<string>> GetAcademicExcellenceAward();
        Task<IEnumerable<string>> GetGradeRangeEnglish();
        Task<IEnumerable<string>> GetGradeRangeMath();
        Task<IEnumerable<string>> GetGradeRangeScience();
        Task<IEnumerable<string>> GetGPA();
        Task<IEnumerable<string>> GetProgramming1Grade();
    }
}
