using StudentDataAPI.Repositories.Students;

namespace StudentDataAPI.Services.StudentServices
{
    public class SHSInformationService : ISHSInformationService
    {
        private readonly ISHSInformationRepository _repository;

        public SHSInformationService(ISHSInformationRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<string>> GetAcademicExcellenceAward()
        {
            var award = await _repository.GetAcademicExcellenceAward();

            return award;
        }

        public async Task<IEnumerable<string>> GetAcademicRank()
        {
            var rank = await _repository.GetAcademicRank();

            return rank;
        }

        public async Task<IEnumerable<string>> GetGPA()
        {
            var gpa = await _repository.GetGPA();

            return gpa;
        }

        public async Task<IEnumerable<string>> GetGradeRangeEnglish()
        {
            var rangeEnglish = await _repository.GetGradeRangeEnglish();

            return rangeEnglish;
        }

        public async Task<IEnumerable<string>> GetGradeRangeMath()
        {
            var rangeMath = await _repository.GetGradeRangeMath();

            return rangeMath;
        }

        public async Task<IEnumerable<string>> GetGradeRangeScience()
        {
            var rangeScience = await _repository.GetGradeRangeScience();

            return rangeScience;
        }

        public async Task<IEnumerable<string>> GetInTopTen()
        {
            var inTopTen = await _repository.GetInTopTen();

            return inTopTen;
        }

        public async Task<IEnumerable<string>> GetJoinedScienceHigh()
        {
            var joinedScienceHigh = await _repository.GetJoinedScienceHigh();   

            return joinedScienceHigh;
        }

        public async Task<IEnumerable<string>> GetProgramming1Grade()
        {
            var prog1Grade = await _repository.GetProgramming1Grade();

            return prog1Grade;
        }

        public async Task<IEnumerable<string>> GetScienceHighSchool()
        {
            var getScience = await _repository.GetScienceHighSchool();

            return getScience;
        }

        public async Task<IEnumerable<string>> GetSeniorHighSchool()
        {
            var getSeniorHighSchool = await _repository.GetSeniorHighSchool();

            return getSeniorHighSchool;
        }

        public async Task<IEnumerable<string>> GetStrand()
        {
            var getStrand = await _repository.GetStrand();

            return getStrand;
        }

        public async Task<IEnumerable<string>> GetTypeOfSchool()
        {
            var getSchoolType = await _repository.GetTypeOfSchool();

            return getSchoolType;
        }

        public async Task<IEnumerable<string>> GetWithHonors()
        {
            var getWithHonors = await _repository.GetWithHonors();

            return getWithHonors;
        }
    }

    /*
      1.Course  
        ///     
        ///     2.Year Level
        ///     
        ///     3. Programming 1 Professor
        ///     
        ///     4.Mode of delivery
        ///     
        ///     5. Has scholarship
        ///     
        ///     6. Scholarship type
        ///     
        ///     7. Has experience in programming
        ///      
        ///     8. Programming languages experienced
        ///     
        ///     9. Has Device
        ///     
        ///     10. Is located within cebu
        ///     
        ///     11. Current place staying
        ///
        ///     12. Has Enough Space
        ///     
        ///     13. Mode of transport going to school
        ///     
        ///     14. Number of commutes going to school
        ///     
        ///     15. Commute duration going to school
        ///     
        ///     16. Feeling when arriving to school
        ///     
        ///     17. Mode of transport going home
        ///     
        ///     18. Number of commutes going home
        ///     
        ///     19. Commute duration going thome
        ///     
        ///     20. Feeling when arriving home
        ///     
        ///     21. Reason you pursue course*/
}
