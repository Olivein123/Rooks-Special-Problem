using StudentDataAPI.Models;

namespace StudentDataAPI.Services.StudentServices
{
    public interface IStudentService
    {
        Task<IEnumerable<PersonalInformation>> GetPersonalInformation();
        Task<IEnumerable<FamilyProfile>> GetFamilyProfile();
        Task<IEnumerable<SHSInformation>> GetSHSInformation();
        Task<IEnumerable<CollegeInformation>> GetCollegeInformation();
        Task<PersonalInformation> GetPersonalInformationById(int id);
    }
}
