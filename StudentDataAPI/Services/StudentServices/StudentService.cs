using AutoMapper;
using StudentDataAPI.Models;
using StudentDataAPI.Repositories.Students;

namespace StudentDataAPI.Services.StudentServices
{
    public class StudentService : IStudentService
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public Task<IEnumerable<Student>> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public async Task<Student> GetStudentById(int studentId)
        {
            var student = await _repository.GetStudentById(studentId);

            return _mapper.Map<Student>(student);
        }
    }
}
