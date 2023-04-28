using Microsoft.AspNetCore.Mvc;

namespace Task23.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        [Route("multiply")]
        public IActionResult Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return Ok(result);
        }
        [HttpGet]
        [Route("add")]
        public IActionResult Add(int num1, int num2)
        {
            int result = num1 + num2;
            return Ok(result);
        }
    }
}
