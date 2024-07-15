using CoffeeMachine.Core.Model;

namespace CoffeeMachine.Core.Abstract
{
    public interface IBrewCoffeeService
    {
        Task<BrewCoffeeResponse> BrewCoffee();
    }
}
