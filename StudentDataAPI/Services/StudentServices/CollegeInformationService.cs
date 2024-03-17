using StudentDataAPI.Repositories.Students;

namespace StudentDataAPI.Services.StudentServices
{
    public class CollegeInformationService : ICollegeInformationService
    {
        private readonly ICollegeInformationRepository _repository;

        public CollegeInformationService(ICollegeInformationRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<string>> GetArriveHomeFeeling()
        {
            var arriveHomeFeeling = await _repository.GetArriveHomeFeeling();

            return arriveHomeFeeling;
        }

        public async Task<IEnumerable<string>> GetArriveSchoolFeeling()
        {
            var arriveSchoolFeeling = await _repository.GetArriveSchoolFeeling();

            return arriveSchoolFeeling;
        }

        public async Task<IEnumerable<string>> GetCommuteCountToHome()
        {
            var commuteCountHome = await _repository.GetCommuteCountToHome();

            return commuteCountHome;
        }

        public async Task<IEnumerable<string>> GetCommuteCountToSchool()
        {
            var commuteCountSchool = await _repository.GetCommuteCountToSchool();

            return commuteCountSchool;
        }

        public async Task<IEnumerable<string>> GetCommuteDurationToHome()
        {
            var commuteDurationHome = await _repository.GetCommuteDurationToHome();

            return commuteDurationHome;
        }

        public async Task<IEnumerable<string>> GetCommuteDurationToSchool()
        {
            var commuteDurationSchool = await _repository.GetCommuteDurationToSchool();

            return commuteDurationSchool;
        }

        public async Task<IEnumerable<string>> GetCourse()
        {
            var course = await _repository.GetCourse();

            return course;
        }

        public async Task<IEnumerable<string>> GetCurrentPlace()
        {
            var currentPlace = await _repository.GetCurrentPlace();

            return currentPlace;
        }

        public async Task<IEnumerable<string>> GetHasDevice()
        {
            var hasDevice = await _repository.GetHasDevice();

            return hasDevice;
        }  

        public async Task<IEnumerable<string>> GetHasEnoughSpace()
        {
            var hasEnoughSpace = await _repository.GetHasEnoughSpace();

            return hasEnoughSpace;
        }

        public async Task<IEnumerable<string>> GetHasProgrammingExperience()
        {
            var programmingExperience = await _repository.GetHasProgrammingExperience();

            return programmingExperience;
        }

        public async Task<IEnumerable<string>> GetHasRoom()
        {
            var hasRoom = await _repository.GetHasRoom();

            return hasRoom;
        }

        public async Task<IEnumerable<string>> GetHasScholarship()
        {
            var hasScholarship = await _repository.GetHasScholarship();

            return hasScholarship;
        }

        public async Task<IEnumerable<string>> GetIsInCebu()
        {
            var isInCebu = await _repository.GetIsInCebu();

            return isInCebu;
        }

        public async Task<IEnumerable<string>> GetModeOfDelivery()
        {
            var modeOfDelivery = await _repository.GetModeOfDelivery();

            return modeOfDelivery;
        }

        public async Task<IEnumerable<string>> GetModeofTransportToHome()
        {
            var modeOfTransportToHome = await _repository.GetModeofTransportToHome();

            return modeOfTransportToHome;
        }

        public async Task<IEnumerable<string>> GetModeofTransportToSchool()
        {
            var modeOfTransportToSchool = await _repository.GetModeofTransportToSchool();

            return modeOfTransportToSchool;
        }

        public async Task<IEnumerable<string>> GetProg1Professor()
        {
            var prog1Professor = await _repository.GetProg1Professor();

            return prog1Professor;
        }

        public async Task<IEnumerable<string>> GetProgrammingLanguages()
        {
            var programmingLanguage = await _repository.GetProgrammingLanguages();

            return programmingLanguage;
        }

        public async Task<IEnumerable<string>> GetPursueCourseReason()
        {
            var pursueCourseReason = await _repository.GetPursueCourseReason();

            return pursueCourseReason;
        }

        public async Task<IEnumerable<string>> GetScholarshipType()
        {
            var scholarshipType = await _repository.GetScholarshipType();

            return scholarshipType;
        }
    }
}
