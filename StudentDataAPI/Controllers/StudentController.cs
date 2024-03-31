using Microsoft.AspNetCore.Mvc;
using StudentDataAPI.Models;
using StudentDataAPI.Services.StudentServices;

namespace StudentDataAPI.Controllers
{

    [Route("api/Student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly ILogger<StudentController> _logger;


        public StudentController(IStudentService studentService, ILogger<StudentController> logger)
        {
            _studentService = studentService;
            _logger = logger;
        }

        /// <summary>
        /// Gets student information based on given student id.
        /// </summary>
        /// <returns>A student.</returns>

        [HttpGet("{studentId}", Name = "GetStudentById")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetStudentById(int studentId)
        {
            var student = await _studentService.GetStudentById(studentId);
            if (student == null)
            {
                _logger.LogInformation("No student with Id number:" + studentId + " found.");
                return NotFound(); // Status Code 404
            }

            return Ok(student);
        }


        /// <summary>
        /// Gets all student information.
        /// </summary>
        /// <returns>A student.</returns>

        [HttpGet(Name = "GetAll")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _studentService.GetAllStudents();
            if (!students.Any())
            {
                _logger.LogInformation("No students found.");
                return NotFound(); // Status Code 404
            }

            return Ok(students);
        }
    }

}
