using CoffeeMachine.Core.Abstract;
using CoffeeMachine.Core.Service;
using CoffeeMachine.Integration;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeMachine.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCoffeeMachineService(this IServiceCollection services)
            => services
            .AddSingleton<IBrewCounterService, BrewCounterService>()
            .AddScoped<CoffeeMachineService>()
            .AddScoped<TeapotService>()
            .AddScoped<IBrewCoffeeService, BrewIcedCoffeeService>()
            .AddScoped<ICoffeeMachineService>(sp => DateTime.Today.Day == 1 && DateTime.Today.Month == 4
                                                    ? sp.GetService<TeapotService>()
                                                    : sp.GetService<CoffeeMachineService>())
            .AddWeatherService();
    }
}
