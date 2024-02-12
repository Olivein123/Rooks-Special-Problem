using StudentDataAPI.Models;

namespace StudentDataAPI.Repositories.Students
{
    public interface IStudentRepositories
    {
        Task<IEnumerable<Student>> GetAllStudents();
    }
}
