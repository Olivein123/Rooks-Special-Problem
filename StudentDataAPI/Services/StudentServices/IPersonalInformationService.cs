namespace StudentDataAPI.Services.StudentServices
{
    public interface IPersonalInformationService
    {
        Task<IEnumerable<string>> GetMotherOccupation();
        Task<IEnumerable<string>> GetFundSource();
    }
}
