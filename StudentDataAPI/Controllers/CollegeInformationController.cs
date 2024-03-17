using Microsoft.AspNetCore.Mvc;
using StudentDataAPI.Models;
using StudentDataAPI.Services.StudentServices;

namespace StudentDataAPI.Controllers
{

    [Route("api/GetStudentCollegeInformation")]
    [ApiController]
    public class CollegeInformationController : ControllerBase
    {
        private readonly ICollegeInformationService _collegeInformationService;
        private readonly ILogger<CollegeInformationController> _logger;


        public CollegeInformationController(ICollegeInformationService collegeInformationService, ILogger<CollegeInformationController> logger)
        {
            _collegeInformationService = collegeInformationService;
            _logger = logger;
        }

        /// <summary>
        /// Gets a list of college information field based on given output.
        /// </summary>
        /// <returns>A list of college information column based in given input.</returns>
        /// <remarks>
        /// Legend:
        /// 
        ///     1.Course  
        ///     
        ///     2.Year Level
        ///     
        ///     3. Programming 1 Professor
        ///     
        ///     4.Mode of delivery
        ///     
        ///     5. Has scholarship
        ///     
        ///     6. Scholarship type
        ///     
        ///     7. Has experience in programming
        ///      
        ///     8. Programming languages experienced
        ///     
        ///     9. Has Device
        ///     
        ///     10. Is located within cebu
        ///     
        ///     11. Current place staying
        ///
        ///     12. Has Enough Space
        ///     
        ///     13. Mode of transport going to school
        ///     
        ///     14. Number of commutes going to school
        ///     
        ///     15. Commute duration going to school
        ///     
        ///     16. Feeling when arriving to school
        ///     
        ///     17. Mode of transport going home
        ///     
        ///     18. Number of commutes going home
        ///     
        ///     19. Commute duration going thome
        ///     
        ///     20. Feeling when arriving home
        ///     
        ///     21. Reason you pursue course
        /// </remarks>
        [HttpGet(Name = "GetAllCollegeInformation")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllCollegeInformation([FromQuery] int choice)
        {
            switch (choice)
            {
                case 1:
                    try
                    {
                        var course = await _collegeInformationService.GetCourse();
                        if (!course.Any())
                        {
                            _logger.LogInformation("No course information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(course);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 2:
                    try
                    {
                        var yearLevel = await _collegeInformationService.GetYearLevel();
                        if (!yearLevel.Any())
                        {
                            _logger.LogInformation("No year level information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(yearLevel);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 3:
                    try
                    {
                        var programming1Prof = await _collegeInformationService.GetProg1Professor();
                        if (!programming1Prof.Any())
                        {
                            _logger.LogInformation("No programming 1 professor information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(programming1Prof);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 4:
                    try
                    {
                        var modeOfDelivery = await _collegeInformationService.GetModeOfDelivery();
                        if (!modeOfDelivery.Any())
                        {
                            _logger.LogInformation("No mode of delivery information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(modeOfDelivery);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 5:
                    try
                    {
                        var scholarship = await _collegeInformationService.GetHasScholarship();
                        if (!scholarship.Any())
                        {
                            _logger.LogInformation("No scholarship information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(scholarship);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 6:
                    try
                    {
                        var scholarshipType = await _collegeInformationService.GetScholarshipType();
                        if (!scholarshipType.Any())
                        {
                            _logger.LogInformation("No scholarship type information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(scholarshipType);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 7:
                    try
                    {
                        var hasExperience = await _collegeInformationService.GetHasProgrammingExperience();
                        if (!hasExperience.Any())
                        {
                            _logger.LogInformation("No programming experience information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(hasExperience);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 8:
                    try
                    {
                        var programmingLanguages = await _collegeInformationService.GetProgrammingLanguages();
                        if (!programmingLanguages.Any())
                        {
                            _logger.LogInformation("No programming languages information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(programmingLanguages);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 9:
                    try
                    {
                        var hasDevice = await _collegeInformationService.GetHasDevice();
                        if (!hasDevice.Any())
                        {
                            _logger.LogInformation("No has device information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(hasDevice);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 10:
                    try
                    {
                        var isInCebu = await _collegeInformationService.GetIsInCebu();
                        if (!isInCebu.Any())
                        {
                            _logger.LogInformation("No is in cebu information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(isInCebu);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 11:
                    try
                    {
                        var currentPlace = await _collegeInformationService.GetCurrentPlace();
                        if (!currentPlace.Any())
                        {
                            _logger.LogInformation("No current place information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(currentPlace);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 12:
                    try
                    {
                        var hasEnoughSpace = await _collegeInformationService.GetHasEnoughSpace();
                        if (!hasEnoughSpace.Any())
                        {
                            _logger.LogInformation("No has enough space information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(hasEnoughSpace);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 13:
                    try
                    {
                        var modeOfTransportGoingSchool = await _collegeInformationService.GetModeofTransportToSchool();
                        if (!modeOfTransportGoingSchool.Any())
                        {
                            _logger.LogInformation("No mode of transportation information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(modeOfTransportGoingSchool);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 14:
                    try
                    {
                        var numberOfTransportGoingSchool = await _collegeInformationService.GetCommuteCountToSchool();
                        if (!numberOfTransportGoingSchool.Any())
                        {
                            _logger.LogInformation("No commute count information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(numberOfTransportGoingSchool);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 15:
                    try
                    {
                        var commuteDurationSchool = await _collegeInformationService.GetCommuteDurationToSchool();
                        if (!commuteDurationSchool.Any())
                        {
                            _logger.LogInformation("No commute duration information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(commuteDurationSchool);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 16:
                    try
                    {
                        var arriveSchoolFeeling = await _collegeInformationService.GetArriveSchoolFeeling();
                        if (!arriveSchoolFeeling.Any())
                        {
                            _logger.LogInformation("No arrive school feeling information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(arriveSchoolFeeling);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 17:
                    try
                    {
                        var modeOfTransportGoingHome = await _collegeInformationService.GetModeofTransportToHome();
                        if (!modeOfTransportGoingHome.Any())
                        {
                            _logger.LogInformation("No mode of transport information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(modeOfTransportGoingHome);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 18:
                    try
                    {
                        var numberOfTransportGoingHome = await _collegeInformationService.GetCommuteCountToHome();
                        if (!numberOfTransportGoingHome.Any())
                        {
                            _logger.LogInformation("No commute count information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(numberOfTransportGoingHome);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 19:
                    try
                    {
                        var commuteDurationHome = await _collegeInformationService.GetCommuteDurationToHome();
                        if (!commuteDurationHome.Any())
                        {
                            _logger.LogInformation("No commute duration information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(commuteDurationHome);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 20:
                    try
                    {
                        var arriveHomeFeeling = await _collegeInformationService.GetArriveHomeFeeling();
                        if (!arriveHomeFeeling.Any())
                        {
                            _logger.LogInformation("No arrive home feeling information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(arriveHomeFeeling);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 21:
                    try
                    {
                        var reason = await _collegeInformationService.GetPursueCourseReason();
                        if (!reason.Any())
                        {
                            _logger.LogInformation("No pursue course reason information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(reason);
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
