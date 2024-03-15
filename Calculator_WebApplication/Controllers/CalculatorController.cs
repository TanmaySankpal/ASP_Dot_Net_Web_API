using ASPNetCoreWebAPIDemo.Services;
using Calculator_WebApplication.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Calculator_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        ICalculatorService _calculatorService;
        public CalculatorController(ICalculatorService service)
        {
            _calculatorService = service;
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Addition(NumberSet numberModel)
        {

            try
            {
                var model = _calculatorService.Addition(numberModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
            
        }
    }
}
