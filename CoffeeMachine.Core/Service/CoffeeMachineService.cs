using CoffeeMachine.Core.Abstract;
using CoffeeMachine.Core.Exceptions;
using CoffeeMachine.Core.Model;

namespace CoffeeMachine.Core.Service
{
    public class CoffeeMachineService : ICoffeeMachineService
    {
        private readonly IBrewCoffeeService _brewCoffeeService;
        private readonly IBrewCounterService _brewCounterService;

        public CoffeeMachineService(IBrewCoffeeService brewCoffeeService, IBrewCounterService brewCounterService)
        {
            _brewCoffeeService = brewCoffeeService ?? throw new ArgumentNullException(nameof(brewCoffeeService));
            _brewCounterService = brewCounterService ?? throw new ArgumentNullException(nameof(brewCoffeeService));
        }

        public async Task<BrewCoffeeResponse> BrewCoffee()
        {
            if (_brewCounterService.IsServiceAvailable())
            {
                _brewCounterService.CountBrew();
                return await _brewCoffeeService.BrewCoffee();
            }
            _brewCounterService.ResetBrewCounter();
            throw new ServiceUnavailableException();
        }
    }
}
