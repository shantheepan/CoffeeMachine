using CoffeeMachine.Core.Model;

namespace CoffeeMachine.Core.Abstract
{
    public interface ICoffeeMachineService
    {
        Task<BrewCoffeeResponse> BrewCoffee();
    }
}
