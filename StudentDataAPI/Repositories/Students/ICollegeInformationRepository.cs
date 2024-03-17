namespace StudentDataAPI.Repositories.Students
{
    public interface ICollegeInformationRepository
    {
        Task<IEnumerable<string>> GetCourse();
        Task<IEnumerable<string>> GetProg1Professor();
        Task<IEnumerable<string>> GetModeOfDelivery();
        Task<IEnumerable<string>> GetHasScholarship();
        Task<IEnumerable<string>> GetScholarshipType();
        Task<IEnumerable<string>> GetHasProgrammingExperience();
        Task<IEnumerable<string>> GetProgrammingLanguages();
        Task<IEnumerable<string>> GetHasDevice();
        Task<IEnumerable<string>> GetIsInCebu();
        Task<IEnumerable<string>> GetCurrentPlace();
        Task<IEnumerable<string>> GetHasRoom();
        Task<IEnumerable<string>> GetHasEnoughSpace();
        Task<IEnumerable<string>> GetModeofTransportToSchool();
        Task<IEnumerable<string>> GetCommuteCountToSchool();
        Task<IEnumerable<string>> GetCommuteDurationToSchool();
        Task<IEnumerable<string>> GetArriveSchoolFeeling();
        Task<IEnumerable<string>> GetModeofTransportToHome();
        Task<IEnumerable<string>> GetCommuteCountToHome();
        Task<IEnumerable<string>> GetCommuteDurationToHome();
        Task<IEnumerable<string>> GetArriveHomeFeeling();
        Task<IEnumerable<string>> GetPursueCourseReason();

    }
}
