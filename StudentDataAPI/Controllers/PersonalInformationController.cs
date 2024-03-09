using Microsoft.AspNetCore.Mvc;
using StudentDataAPI.Models;
using StudentDataAPI.Services.StudentServices;

namespace StudentDataAPI.Controllers
{

    [Route("api/GetStudentPersonalInformation")]
    [ApiController]
    public class PersonalInformationController : ControllerBase
    {
        private readonly IPersonalInformationService _personalInfoService;
        private readonly ILogger<PersonalInformationController> _logger;


        public PersonalInformationController(IPersonalInformationService personalInfoService, ILogger<PersonalInformationController> logger)
        {
            _personalInfoService = personalInfoService;
            _logger = logger;
        }

        [HttpGet(Name = "GetAllPersonalInformation")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllPersonalInformation([FromQuery] int choice)
        {
            /*1 = Name    
              2 = Adresss
              3 = Fund Source
              4 = Fund Type
              5 = Job
              6 = Salary Enough
              7 = Salary Range
            */
            switch (choice)
            {
                case 3:
                    try
                    {
                        var fundSourceInfo = await _personalInfoService.GetFundSource();
                        if (!fundSourceInfo.Any())
                        {
                            _logger.LogInformation("No fund source information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(fundSourceInfo);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }

                default: return NoContent();
            }
        }
    }

        
}
