using Calculator.Application.Services;
using Calculator.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Calculator.Api.Controllers
{
    [ApiController]
    [Route("/api/[Controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorController(CalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpPost("calculate")]
        public ActionResult<double> Calculate([FromBody] CalculatorOperation operation, string operationType)
        {
            try
            {
                return Ok(operationType switch
                {
                    "sum" => _calculatorService.Add(operation.Number1, operation.Number2),
                    "substract" => _calculatorService.Substract(operation.Number1, operation.Number2),
                    "multiply" => _calculatorService.Multiply(operation.Number1, operation.Number2),
                    "divide" => _calculatorService.Divide(operation.Number1, operation.Number2),
                    _ => BadRequest("Invalid operation")
                });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("factorial")]
        public ActionResult<string> Factorial([FromBody] int number)
        {
            try {
                var result = _calculatorService.Factorial(number);
                return Ok(result.ToString());
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
