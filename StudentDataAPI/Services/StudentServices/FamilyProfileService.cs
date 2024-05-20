using StudentDataAPI.Repositories.Students;

namespace StudentDataAPI.Services.StudentServices
{
    public class FamilyProfileService : IFamilyProfileService
    {
        private readonly IFamilyProfileRepository _repository;

        public FamilyProfileService(IFamilyProfileRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<string>> GetDependentSiblings()
        {
            var dependentSiblings = await _repository.GetDependentSiblings();

            return dependentSiblings;
        }

        public async Task<IEnumerable<string>> GetFatherOccupation()
        {
            var fatherOccupation = await _repository.GetFatherOccupation();

            return fatherOccupation;
        }

        public async Task<IEnumerable<string>> GetGraduatedSiblings()
        {
            var graduatedSublings = await _repository.GetGraduatedSiblings();

            return graduatedSublings;
        }

        public async Task<IEnumerable<string>> GetMotherOccupation()
        {
            var motherOccupation = await _repository.GetMotherOccupation();

            return motherOccupation;
        }

        public async Task<IEnumerable<string>> GetTotalIncome()
        {
            var totalIncome = await _repository.GetTotalIncome();

            return totalIncome;
        }

        public async Task<IEnumerable<string>> GetTotalSiblings()
        {
            var totalSiblings = await _repository.GetTotalSiblings();

            return totalSiblings;
        }
    }
}
