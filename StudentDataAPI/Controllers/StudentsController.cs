using Microsoft.AspNetCore.Mvc;
using StudentDataAPI.Models;
using StudentDataAPI.Services.StudentServices;

namespace StudentDataAPI.Controllers
{
    [Route("api/Students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _charService;
        private readonly ILogger<StudentsController> _logger;


        public StudentsController(IStudentService charService, ILogger<StudentsController> logger)
        {
            _charService = charService;
            _logger = logger;
        }


        [HttpGet(Name = "GetAllStudents")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllStudents()
        {
            try
            {
                var students = await _charService.GetAllStudents();
                if (!students.Any())
                {
                    _logger.LogInformation("No students found.");
                    return NoContent(); // Status Code 204
                }

                return Ok(students);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return StatusCode(500, e.Message);
            }
        }
    }
}
