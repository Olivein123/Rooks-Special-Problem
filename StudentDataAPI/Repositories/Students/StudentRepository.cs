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

    public async Task<IEnumerable<Student>> GetAllStudents()
    {
        var sql = "SELECT * " +
            " FROM Personal_Info P" +
            " INNER JOIN Family_Profile F ON P.IdNumber = F.StudentId" +
            " INNER JOIN SHS_Information S ON P.IdNumber = S.StudentId" +
            " INNER JOIN College_Information C ON P.IdNumber = C.StudentId";

        using (var con = _context.CreateConnection())
        {
            return await con.QueryAsync<Student, PersonalInformation, FamilyProfile, SHSInformation, CollegeInformation, Student>(sql, MapStudent);

        }
    }

    private static Student MapStudent(Student student, PersonalInformation personal,  FamilyProfile family, SHSInformation shs, CollegeInformation college)
    {
        student.PersonalInformation = personal;
        student.FamilyProfile = family;
        student.SHSInformation = shs;
        student.CollegeInformation = college;
        return student;
    }
    
}
