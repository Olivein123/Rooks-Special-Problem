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

        public async Task<IEnumerable<string>> GetAddress()
        {
            var address = await _repository.GetAddress();

            return address;
        }
        public async Task<IEnumerable<string>> GetFundSource()
        {
            var fundSource = await _repository.GetFundSource();

            return fundSource;
        }

        public async Task<IEnumerable<string>> GetFundType()
        {
            var fundType = await _repository.GetFundType();

            return fundType;
        }

        public async Task<IEnumerable<string>> GetJob()
        {
            var job = await _repository.GetJob();

            return job;
        }


        public async Task<IEnumerable<string>> GetSalaryEnough()
        {
            var salaryenough = await _repository.GetSalaryEnough();

            return salaryenough;
        }

        public async Task<IEnumerable<string>> GetSalaryRange()
        {
            var salaryrange = await _repository.GetSalaryRange();

            return salaryrange;
        }
    }        
        
}
