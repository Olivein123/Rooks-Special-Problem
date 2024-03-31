using StudentDataAPI.Models;

namespace StudentDataAPI.Services.StudentServices
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudent();
        Task<Student> GetStudentById(int studentId);
    }
}
