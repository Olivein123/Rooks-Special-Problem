using StudentDataAPI.Repositories.Students;

namespace StudentDataAPI.Services.StudentServices
{
    public class PersonalInformationService : IPersonalInformationService
    {
        private readonly IPersonalInformationRepository _repository;

        public PersonalInformationService(IPersonalInformationRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<string>> GetFundSource()
        {
            var fundSource = await _repository.GetFundSource();

            return fundSource;
        }

        public async Task<IEnumerable<string>> GetMotherOccupation()
        {
            var motherOccupation = await _repository.GetMotherOccupation();

            return motherOccupation;
        }
    }        
        
}
