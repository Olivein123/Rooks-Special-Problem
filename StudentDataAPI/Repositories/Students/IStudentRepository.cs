using StudentDataAPI.Models;

namespace StudentDataAPI.Repositories.Students
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudents();
        Task<Student> GetStudentById(int studentId);   
    }
}
