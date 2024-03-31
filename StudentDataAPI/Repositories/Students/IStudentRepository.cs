using StudentDataAPI.Models;

namespace StudentDataAPI.Repositories.Students
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudent();
        Task<Student> GetStudentById(int studentId);   
    }
}
