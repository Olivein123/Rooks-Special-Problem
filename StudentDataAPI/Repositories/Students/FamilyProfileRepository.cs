using StudentDataAPI.Context;
using Dapper;


namespace StudentDataAPI.Repositories.Students
{
    public class FamilyProfileRepository : IFamilyProfileRepository
    {
        private readonly DapperContext _context;

        public FamilyProfileRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<string>> GetDependentSiblings()
        {
            var sql = "Select ParentDependentSiblings From Family_Profile ";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetFatherOccupation()
        {
            var sql = "Select FatherOccupation From Family_Profile";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetGraduatedSiblings()
        {
            var sql = "Select GraduatedSiblings From Family_Profile";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetMotherOccupation()
        {
            var sql = "Select MotherOccupation From Family_Profile";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetTotalIncome()
        {
            var sql = "Select TotalIncome From Family_Profile";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetTotalSiblings()
        {
            var sql = "Select TotalSiblings From Family_Profile";

            using (var con = _context.CreateConnection())
            {
                return await con.QueryAsync<string>(sql);
            }
        }
    }
}
