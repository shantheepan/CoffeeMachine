using CoffeeMachine.Core.Abstract;
using CoffeeMachine.Core.Exceptions;
using CoffeeMachine.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMachine.Api.Controllers
{
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        private readonly ICoffeeMachineService _coffeeMachineService;

        public CoffeeController(ICoffeeMachineService coffeeMachineService) 
            => _coffeeMachineService = coffeeMachineService;

        [HttpGet]
        [Route("brew-coffee")]
        public async Task<ActionResult<BrewCoffeeResponse>> Get()
        {
            try
            {
                return Ok(await _coffeeMachineService.BrewCoffee());
            }
            catch (ServiceUnavailableException)
            {
                return StatusCode(503, new BrewCoffeeResponse());
            }
            catch (IAmATeapotException)
            {
                return StatusCode(418, new BrewCoffeeResponse());
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Error");
            }
        }
    }
}
