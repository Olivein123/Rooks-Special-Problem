using StudentDataAPI.DTOS;
using StudentDataAPI.Models;

namespace StudentDataAPI.Services.StudentServices
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDto>> GetAllStudents();
        Task<StudentDto> GetStudentById(int studentId);
    }
}
