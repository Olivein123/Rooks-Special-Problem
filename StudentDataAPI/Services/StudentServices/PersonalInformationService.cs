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

        public async Task<IEnumerable<string>> GetFundType()
        {
            var fundSource = await _repository.GetFundType();

            return fundSource;
        }

        public async Task<IEnumerable<string>> GetJob()
        {
            var fundSource = await _repository.GetJob();

            return fundSource;
        }


        public async Task<IEnumerable<string>> GetSalaryEnough()
        {
            var fundSource = await _repository.GetSalaryEnough();

            return fundSource;
        }

        public async Task<IEnumerable<string>> GetSalaryRange()
        {
            var fundSource = await _repository.GetSalaryRange();

            return fundSource;
        }
    }        
        
}
