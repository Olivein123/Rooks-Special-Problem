using Dapper;
using StudentDataAPI.Context;

namespace StudentDataAPI.Repositories.Students
{
    public class CollegeInformationRepository : ICollegeInformationRepository
    {
        private readonly DapperContext _context;

        public CollegeInformationRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<string>> GetArriveHomeFeeling()
        {
            var sql = "Select ArriveHomeFeeling From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetArriveSchoolFeeling()
        {
            var sql = "Select ArriveSchoolFeeling From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetCommuteCountToHome()
        {
            var sql = "Select CommuteCountToHome From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetCommuteCountToSchool()
        {
            var sql = "Select CommuteCountToSchool From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetCommuteDurationToHome()
        {
            var sql = "Select CommuteDurationToHome From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetCommuteDurationToSchool()
        {
            var sql = "Select CommuteDurationToSchool From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetCourse()
        {
            var sql = "Select Course From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetCurrentPlace()
        {
            var sql = "Select CurrentPlace From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetHasDevice()
        {
            var sql = "Select HasDevice From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetHasEnoughSpace()
        {
            var sql = "Select HasEnoughSpace From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetHasProgrammingExperience()
        {
            var sql = "Select ProgrammingLanguages From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetHasRoom()
        {
            var sql = "Select HasRoom From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetHasScholarship()
        {
            var sql = "Select HasScholarship From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetIsInCebu()
        {
            var sql = "Select IsInCebu From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetModeOfDelivery()
        {
            var sql = "Select ModeOfDelivery From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetModeofTransportToHome()
        {
            var sql = "Select ModeOfTransportationHome From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetModeofTransportToSchool()
        {
            var sql = "Select ModeOfTransportationSchool From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetProg1Professor()
        {
            var sql = "Select Prog1Professor From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetProgrammingLanguages()
        {
            var sql = "Select ProgrammingLanguages From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetScholarshipType()
        {
            var sql = "Select ScholarshipType From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetPursueCourseReason()
        {
            var sql = "Select ScholarshipType From College_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }
    }
}
