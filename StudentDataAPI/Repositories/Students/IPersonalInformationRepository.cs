using StudentDataAPI.Models;

namespace StudentDataAPI.Repositories.Students
{
    public interface IPersonalInformationRepository
    {
        Task<IEnumerable<string>> GetMotherOccupation();
        Task<IEnumerable<string>> GetFundSource();
    }
}
