using StudentDataAPI.Models;
using Dapper;

using StudentDataAPI.Context;

namespace StudentDataAPI.Repositories.Students;
public class StudentRepository : IStudentRepositories
    {
        private readonly DapperContext _context;

        public StudentRepository(DapperContext context)
        {
            _context = context;
        }

    public async Task<IEnumerable<PersonalInformation>> GetPersonalInformation()
    {
       var sql = "SELECT * FROM Personal_Info";

       using (var con = _context.CreateConnection())
        {
            return await con.QueryAsync<PersonalInformation>(sql);
        }

    }

    public async Task<IEnumerable<FamilyProfile>> GetFamilyProfile()
    {
        var sql = "SELECT * FROM Family_Profile";

        using (var con = _context.CreateConnection())
        {
            return await con.QueryAsync<FamilyProfile>(sql);
        }
    }

    public async Task<IEnumerable<SHSInformation>> GetSHSInformation()
    {
        var sql = "SELECT * FROM SHS_Information";

        using (var con = _context.CreateConnection())
        {
            return await con.QueryAsync<SHSInformation>(sql);
        }
    }

    public async Task<IEnumerable<CollegeInformation>> GetCollegeInformation()
    {
        var sql = "SELECT * FROM College_Information";

        using (var con = _context.CreateConnection())
        {
            return await con.QueryAsync<CollegeInformation>(sql);
        }
    }

    private static Student MapStudent(Student student, PersonalInformation personal, FamilyProfile family, SHSInformation shs, CollegeInformation college)
    {
        student.PersonalInformation = personal;
        student.FamilyProfile = family;
        student.SHSInformation = shs;
        student.CollegeInformation = college;
        return student;
    }
}
