using Microsoft.AspNetCore.Mvc;
using StudentDataAPI.Models;
using StudentDataAPI.Services.StudentServices;

namespace StudentDataAPI.Controllers
{

    [Route("api/GetStudentSeniorHighSchoolInformation")]
    [ApiController]
    public class SHSInformationController : ControllerBase
    {
        private readonly ISHSInformationService _shsInformationService;
        private readonly ILogger<SHSInformationController> _logger;


        public SHSInformationController(ISHSInformationService shsInformationService, ILogger<SHSInformationController> logger)
        {
            _shsInformationService = shsInformationService;
            _logger = logger;
        }

        /// <summary>
        /// Gets a list of family shs information field based on given output.
        /// </summary>
        /// <returns>A list of shs information column based in given input.</returns>
        /// <remarks>
        /// Legend:
        /// 
        ///     1.Type of School  
        ///     
        ///     2.Joined Science High (yes or no)
        ///     
        ///     3.Science High School (name of science high school, if joined)
        ///     
        ///     4.Senior High School
        ///     
        ///     5. Strand
        ///     
        ///     6. With Honors
        ///     
        ///     7. In Top Ten 
        ///      
        ///     8. Academic Rank
        ///     
        ///     9. Academic Excellence Award
        ///     
        ///     10. Grade Range English
        ///     
        ///     11. Grade Range Math
        ///
        ///     12. Grade Range Science
        ///     
        ///     13. GPA
        ///     
        ///     14. Programming 1 Grade
        /// </remarks>
        [HttpGet(Name = "GetAllFamilyProfile")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllFamilyProfile([FromQuery] int choice)
        {
            switch (choice)
            {
                case 1:
                    try
                    {
                        var schoolType = await _shsInformationService.GetTypeOfSchool();
                        if (!schoolType.Any())
                        {
                            _logger.LogInformation("No school type information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(schoolType);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 2:
                    try
                    {
                        var joinedScienceHighSchool = await _shsInformationService.GetJoinedScienceHigh();
                        if (!joinedScienceHighSchool.Any())
                        {
                            _logger.LogInformation("No joined science high school information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(joinedScienceHighSchool);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 3:
                    try
                    {
                        var scienceHighSchool = await _shsInformationService.GetScienceHighSchool();
                        if (!scienceHighSchool.Any())
                        {
                            _logger.LogInformation("No science high school information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(scienceHighSchool);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 4:
                    try
                    {
                        var seniorHighSchool = await _shsInformationService.GetSeniorHighSchool();
                        if (!seniorHighSchool.Any())
                        {
                            _logger.LogInformation("No senior high school information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(seniorHighSchool);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 5:
                    try
                    {
                        var strand = await _shsInformationService.GetStrand();
                        if (!strand.Any())
                        {
                            _logger.LogInformation("No strand information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(strand);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 6:
                    try
                    {
                        var withHonors = await _shsInformationService.GetWithHonors();
                        if (!withHonors.Any())
                        {
                            _logger.LogInformation("No with honors information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(withHonors);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 7:
                    try
                    {
                        var inTopTen = await _shsInformationService.GetInTopTen();
                        if (!inTopTen.Any())
                        {
                            _logger.LogInformation("No top ten information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(inTopTen);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 8:
                    try
                    {
                        var rank = await _shsInformationService.GetAcademicRank();
                        if (!rank.Any())
                        {
                            _logger.LogInformation("No academic rank information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(rank);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 9:
                    try
                    {
                        var awards = await _shsInformationService.GetAcademicExcellenceAward();
                        if (!awards.Any())
                        {
                            _logger.LogInformation("No awards information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(awards);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 10:
                    try
                    {
                        var gradeEnglish = await _shsInformationService.GetGradeRangeEnglish();
                        if (!gradeEnglish.Any())
                        {
                            _logger.LogInformation("No english grade information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(gradeEnglish);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 11:
                    try
                    {
                        var gradeMath = await _shsInformationService.GetGradeRangeMath();
                        if (!gradeMath.Any())
                        {
                            _logger.LogInformation("No math grade information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(gradeMath);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 12:
                    try
                    {
                        var gradeScience = await _shsInformationService.GetGradeRangeScience();
                        if (!gradeScience.Any())
                        {
                            _logger.LogInformation("No science information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(gradeScience);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 13:
                    try
                    {
                        var gpa = await _shsInformationService.GetGPA();
                        if (!gpa.Any())
                        {
                            _logger.LogInformation("No GPA information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(gpa);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 14:
                    try
                    {
                        var prog1Grade = await _shsInformationService.GetProgramming1Grade();
                        if (!prog1Grade.Any())
                        {
                            _logger.LogInformation("No programming 1 grade information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(prog1Grade);
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
