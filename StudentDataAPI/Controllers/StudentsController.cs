using Microsoft.AspNetCore.Mvc;
using StudentDataAPI.Models;
using StudentDataAPI.Services.StudentServices;

namespace StudentDataAPI.Controllers
{
    
    [Route("api/GetStudentInformation")]
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

        /// <summary>
        /// Gets all student related information based on inputted choice
        /// </summary>
        /// <param name="choice">Choice of information to display. 
        /// 1.Personal Information
        /// 2.Family Profile
        /// 3.Senior High School Information
        /// 4.College Information
        /// </param>
        /// <returns>Student information based in given choice</returns>
        /// <remarks>
        /// Gets all student related information based on inputted choice
        /// 1.Personal Information
        /// 2.Family Profile
        /// 3.Senior High School Information
        /// 4.College Information
        /// </remarks>
        [HttpGet(Name = "GetAllInformation")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllPersonalInformation([FromQuery] int choice)
        {
            /*      
              2 = Family Profile
              3 = SHS Information
            */
            switch (choice)
            {
                case 1:
                    try
                    {
                        var personalInfo = await _charService.GetPersonalInformation();
                        if (!personalInfo.Any())
                        {
                            _logger.LogInformation("No personal information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(personalInfo);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                    
                case 2:
                    try
                    {
                        var familyProfile = await _charService.GetFamilyProfile();
                        if (!familyProfile.Any())
                        {
                            _logger.LogInformation("No family profiles found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(familyProfile);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                    
                case 3:
                    try
                    {
                        var shsInfo = await _charService.GetSHSInformation();
                        if (!shsInfo.Any())
                        {
                            _logger.LogInformation("No senior high school information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(shsInfo);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 4:
                    try
                    {
                        var collegeInfo = await _charService.GetCollegeInformation();
                        if (!collegeInfo.Any())
                        {
                            _logger.LogInformation("No personal information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(collegeInfo);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                default: return NoContent();
            }
        }

        [HttpGet("{id}", Name = "GetPersonalInformationById")]
        public async Task<IActionResult> GetPersonalInformation(int id)
        {
            try
            {
                var personalInfo = await _charService.GetPersonalInformationById(id);
                if (personalInfo == null)
                {
                    return NotFound($"Student with Id = {id} is not found!");
                }
                return Ok(personalInfo);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return StatusCode(500, "Something went wrong");
            }
        }
    }
}
