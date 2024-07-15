using CoffeeMachine.Core.Abstract;
using CoffeeMachine.Core.Model;

namespace CoffeeMachine.Core.Service
{
    public class BrewCoffeeService : IBrewCoffeeService
    {
        protected readonly DateTime _prepared;
        private const string ReadyMessage = "Your piping hot coffee is ready";

        public BrewCoffeeService() 
            => _prepared = DateTime.Now;

        public virtual async Task<BrewCoffeeResponse> BrewCoffee() 
            => new BrewCoffeeResponse { message = ReadyMessage, prepared = _prepared.ToString("o") };
    }
}
