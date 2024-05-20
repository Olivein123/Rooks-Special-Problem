namespace StudentDataAPI.Services.StudentServices
{
    public interface IPersonalInformationService
    {
        Task<IEnumerable<string>> GetAddress();
        Task<IEnumerable<string>> GetFundSource();
        Task<IEnumerable<string>> GetFundType();
        Task<IEnumerable<string>> GetJob();
        Task<IEnumerable<string>> GetSalaryEnough();
        Task<IEnumerable<string>> GetSalaryRange();
    }
}
