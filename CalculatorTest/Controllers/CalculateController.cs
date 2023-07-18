using CalculatorTest.BusinessLogic;
using System.Web.Http;

namespace CalculatorTest.Controllers
{
    public class CalculatorController : ApiController
    {
        private readonly ISimpleCalculator _calculator;

        public CalculatorController(ISimpleCalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpGet]
        [Route("api/calculator/add")]
        public IHttpActionResult Add(int start, int amount)
        {
            int result = _calculator.Add(start, amount);
            return Ok(result);
        }

        [HttpGet]
        [Route("api/calculator/subtract")]
        public IHttpActionResult Subtract(int start, int amount)
        {
            int result = _calculator.Subtract(start, amount);
            return Ok(result);
        }
    }
}
