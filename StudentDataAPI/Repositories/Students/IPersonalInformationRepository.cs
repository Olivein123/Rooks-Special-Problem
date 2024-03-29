using StudentDataAPI.Models;

namespace StudentDataAPI.Repositories.Students
{
    public interface IPersonalInformationRepository
    {
        Task<IEnumerable<string>> GetAddress();
        Task<IEnumerable<string>> GetFundSource();
        Task<IEnumerable<string>> GetFundType();
        Task<IEnumerable<string>> GetJob();
        Task<IEnumerable<string>> GetSalaryEnough();
        Task<IEnumerable<string>> GetSalaryRange();

    }
}
