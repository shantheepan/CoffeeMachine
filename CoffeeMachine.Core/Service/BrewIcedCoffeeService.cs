using CoffeeMachine.Core.Model;
using CoffeeMachine.Integration;

namespace CoffeeMachine.Core.Service
{
    public class BrewIcedCoffeeService : BrewCoffeeService
    {
        private readonly IWeatherService _weatherService;

        public BrewIcedCoffeeService(IWeatherService weatherService) 
            => _weatherService = weatherService ?? throw new ArgumentNullException(nameof(weatherService));


        public override async Task<BrewCoffeeResponse> BrewCoffee() 
            => _weatherService.GetCurrentTemperature(0, 0) > 30
                ? new BrewCoffeeResponse { message = "Your refreshing iced coffee is ready", prepared = _prepared.ToString("o") }
                : await base.BrewCoffee();
    }
}
