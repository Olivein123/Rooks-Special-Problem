using Dapper;
using StudentDataAPI.Context;

namespace StudentDataAPI.Repositories.Students
{
    public class SHSInformationRepository : ISHSInformationRepository
    {
        private readonly DapperContext _context;

        public SHSInformationRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<string>> GetAcademicExcellenceAward()
        {
            var sql = "Select AcademicExcellenceAward From SHS_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetAcademicRank()
        {
            var sql = "Select AcademicRank From SHS_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetGPA()
        {
            var sql = "Select GPA From SHS_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetGradeRangeEnglish()
        {
            var sql = " Select GradeRangeEnglish From SHS_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetGradeRangeMath()
        {
            var sql = " Select GradeRangeMath From SHS_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetGradeRangeScience()
        {
            var sql = " Select GradeRangeScience From SHS_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetInTopTen()
        {
            var sql = "Select InTopTen From SHS_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetJoinedScienceHigh()
        {
            var sql = "Select JoinedScienceHigh From SHS_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetProgramming1Grade()
        {
            var sql = "Select Programming1Grade From SHS_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetScienceHighSchool()
        {
            var sql = "Select ScienceHighSchool From SHS_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetSeniorHighSchool()
        {
            var sql = "Select SeniorHighSchool From SHS_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetStrand()
        {
            var sql = "Select Strand From SHS_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetTypeOfSchool()
        {
            var sql = "Select TypeOfSchool From SHS_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetWithHonors()
        {
            var sql = "Select WithHonors From SHS_Information";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }
    }
}
