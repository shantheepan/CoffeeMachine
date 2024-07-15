using CoffeeMachine.Core.Abstract;
using CoffeeMachine.Core.Exceptions;
using CoffeeMachine.Core.Model;

namespace CoffeeMachine.Core.Service
{
    public class TeapotService : ICoffeeMachineService
    {
        public TeapotService() { }

        public async Task<BrewCoffeeResponse> BrewCoffee() 
            => throw new IAmATeapotException();
    }
}
