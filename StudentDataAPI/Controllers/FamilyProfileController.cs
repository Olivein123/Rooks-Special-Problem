using Microsoft.AspNetCore.Mvc;
using StudentDataAPI.Models;
using StudentDataAPI.Services.StudentServices;

namespace StudentDataAPI.Controllers
{

    [Route("api/FamilyProfileInformation")]
    [ApiController]
    public class FamilyProfileController : ControllerBase
    {
        private readonly IFamilyProfileService _familyProfileService;
        private readonly ILogger<FamilyProfileController> _logger;


        public FamilyProfileController(IFamilyProfileService familyProfileService, ILogger<FamilyProfileController> logger)
        {
            _familyProfileService = familyProfileService;
            _logger = logger;
        }

        /// <summary>
        /// Gets a list of family profile information field based on given output.
        /// </summary>
        /// <returns>A list of family profile column based in given input.</returns>
        /// <remarks>
        /// Legend:
        /// 
        ///     1.Mother's Occupation   
        ///     
        ///     2.Father's Occupation
        ///     
        ///     3.Total Income
        ///     
        ///     4.Total Siblings
        ///     
        ///     5.Dependent Siblings  
        ///     
        ///     6.Graduated Siblings
        ///     
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
                        var mothersOccupation = await _familyProfileService.GetMotherOccupation();
                        if (!mothersOccupation.Any())
                        {
                            _logger.LogInformation("No mother's occupation information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(mothersOccupation);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 2:
                    try
                    {
                        var fathersOccupation = await _familyProfileService.GetFatherOccupation();
                        if (!fathersOccupation.Any())
                        {
                            _logger.LogInformation("No father's occupation information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(fathersOccupation);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 3:
                    try
                    {
                        var totalIncome = await _familyProfileService.GetTotalIncome();
                        if (!totalIncome.Any())
                        {
                            _logger.LogInformation("No total income information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(totalIncome);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 4:
                    try
                    {
                        var totalSiblings = await _familyProfileService.GetTotalSiblings();
                        if (!totalSiblings.Any())
                        {
                            _logger.LogInformation("No total siblings information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(totalSiblings);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 5:
                    try
                    {
                        var dependentSiblings = await _familyProfileService.GetDependentSiblings();
                        if (!dependentSiblings.Any())
                        {
                            _logger.LogInformation("No dependent siblings information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(dependentSiblings);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                        return StatusCode(500, e.Message);
                    }
                case 6:
                    try
                    {
                        var graduatedSiblings = await _familyProfileService.GetGraduatedSiblings();
                        if (!graduatedSiblings.Any())
                        {
                            _logger.LogInformation("No graduated siblings information found.");
                            return NoContent(); // Status Code 204
                        }

                        return Ok(graduatedSiblings);
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
