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

        public async Task<IEnumerable<string>> GetAddress()
        {
            var sql = "SELECT Address FROM Personal_Info";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }
        public async Task<IEnumerable<string>> GetFundSource()
        {
            var sql = "SELECT FundSource FROM Personal_Info";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetFundType()
        {
            var sql = "SELECT FundSourceType FROM Personal_Info";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetJob()
        {
            var sql = "SELECT Job FROM Personal_Info";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetSalaryEnough()
        {
            var sql = "SELECT SalaryEnough FROM Personal_Info";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetSalaryRange()
        {
            var sql = "SELECT SalaryRange FROM Personal_Info";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }
    }
}
