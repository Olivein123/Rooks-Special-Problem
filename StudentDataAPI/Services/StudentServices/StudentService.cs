using AutoMapper;
using StudentDataAPI.DTOS;
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
        public async Task<IEnumerable<StudentDto>> GetAllStudents()
        {
            var students = await _repository.GetAllStudents();

            return _mapper.Map<IEnumerable<StudentDto>>(students);
        }

        public async Task<StudentDto> GetStudentById(int studentId)
        {
            var student = await _repository.GetStudentById(studentId);

            return _mapper.Map<StudentDto>(student);
        }
    }
}
