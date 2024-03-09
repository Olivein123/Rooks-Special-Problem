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

        /// <summary>
        /// Gets a list of personal information field based on given output.
        /// </summary>
        /// <returns>A list of students.</returns>
        /// <remarks>
        /// Legend:
        /// 
        ///     1.Address   
        ///     
        ///     2.Fund Source
        ///     
        ///     3.Fund Type 
        ///     
        ///     4.Job  
        ///     
        ///     5.Salary Enough  
        ///     
        ///     6.Salary Range
        ///     
        /// </remarks>
        [HttpGet("{choice}",Name = "GetAllPersonalInformation")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllPersonalInformation([FromQuery] int choice)
        {
            /*    
              1 = Adresss
              2 = Fund Source
              3 = Fund Type
              4 = Job
              5 = Salary Enough
              6 = Salary Range
            */
            switch (choice)
            {
                case 2:
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
                case 3:
                    try
                    {
                        var fundType = await _personalInfoService.GetFundType();
                        if (!fundType.Any())
                        {
                            _logger.LogInformation("No fund type information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(fundType);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 4:
                    try
                    {
                        var job = await _personalInfoService.GetJob();
                        if (!job.Any())
                        {
                            _logger.LogInformation("No job information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(job);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 5:
                    try
                    {
                        var salaryEnough = await _personalInfoService.GetSalaryEnough();
                        if (!salaryEnough.Any())
                        {
                            _logger.LogInformation("No salary information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(salaryEnough);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 6:
                    try
                    {
                        var salaryRange = await _personalInfoService.GetSalaryRange();
                        if (!salaryRange.Any())
                        {
                            _logger.LogInformation("No salary range information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(salaryRange);
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
