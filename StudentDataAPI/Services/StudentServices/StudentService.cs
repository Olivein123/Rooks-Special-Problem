using StudentDataAPI.Models;
using StudentDataAPI.Repositories.Students;

namespace StudentDataAPI.Services.StudentServices
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepositories _repository;

        public StudentService(IStudentRepositories repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<CollegeInformation>> GetCollegeInformation()
        {
            var collegeInfo = await _repository.GetCollegeInformation();

            return collegeInfo;
        }

        public async Task<IEnumerable<FamilyProfile>> GetFamilyProfile()
        {
            var familyProfile = await _repository.GetFamilyProfile();

            return familyProfile;
        }

        public async Task<IEnumerable<PersonalInformation>> GetPersonalInformation()
        {
            var personalInfo = await _repository.GetPersonalInformation();

            return personalInfo;
        }

        public async Task<IEnumerable<SHSInformation>> GetSHSInformation()
        {
            var shsInfo = await _repository.GetSHSInformation();

            return shsInfo;
        }
    }
}
