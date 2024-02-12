using StudentDataAPI.Models;
using StudentDataAPI.Repositories.Students;

namespace StudentDataAPI.Services.StudentServices
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepositories _repository;

        public StudentService(IStudentRepositories repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            var charModels = await _repository.GetAllStudents();

            return charModels;
        }
    }
}
