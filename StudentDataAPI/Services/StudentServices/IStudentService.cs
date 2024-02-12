using StudentDataAPI.Models;

namespace StudentDataAPI.Services.StudentServices
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudents();
    }
}
