namespace StudentDataAPI.Services.StudentServices
{
    public interface IFamilyProfileService
    {
        Task<IEnumerable<string>> GetMotherOccupation();
        Task<IEnumerable<string>> GetFatherOccupation();
        Task<IEnumerable<string>> GetTotalIncome();
        Task<IEnumerable<string>> GetTotalSiblings();
        Task<IEnumerable<string>> GetDependentSiblings();
        Task<IEnumerable<string>> GetGraduatedSiblings();
    }
}
