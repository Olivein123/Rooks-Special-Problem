using Dapper;
using StudentDataAPI.Context;
using StudentDataAPI.Models;

namespace StudentDataAPI.Repositories.Students
{
    public class PersonalInformationRepository : IPersonalInformationRepository
    {
        private readonly DapperContext _context;

        public PersonalInformationRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<string>> GetFundSource()
        {
            var sql = "SELECT FundSource FROM Personal_Info";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetMotherOccupation()
        {
            var sql = "SELECT MotherOccupation FROM Family_Profile";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }


    }
}
