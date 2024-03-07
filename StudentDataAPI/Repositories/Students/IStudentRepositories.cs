using StudentDataAPI.Models;

namespace StudentDataAPI.Repositories.Students
{
    public interface IStudentRepositories
    {
        Task<IEnumerable<PersonalInformation>> GetPersonalInformation();
        Task<IEnumerable<FamilyProfile>> GetFamilyProfile();
        Task<IEnumerable<SHSInformation>> GetSHSInformation();
        Task<IEnumerable<CollegeInformation>> GetCollegeInformation();
    }
}
