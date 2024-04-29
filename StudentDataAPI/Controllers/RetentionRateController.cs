using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
using static StudentDataAPI.RetentionRateModel;

namespace StudentDataAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RetentionRateController : ControllerBase
    {
        private static MLContext mlContext = new MLContext();
        private static ITransformer model = mlContext.Model.Load("RetentionRateModel.zip", out var modelInputSchema);


        [HttpPost]
        public ActionResult<ModelOutput> Predict([FromBody] ModelInput input)
        {
            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(model);
            var result = predEngine.Predict(input);
            return Ok(result);
        }
    }
}
