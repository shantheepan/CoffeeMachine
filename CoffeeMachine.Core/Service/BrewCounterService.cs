using CoffeeMachine.Core.Abstract;

namespace CoffeeMachine.Core.Service
{
    public class BrewCounterService : IBrewCounterService
    {
        private int _counter;
        private const int _maxCounter = 4;

        public BrewCounterService() 
            => _counter = _maxCounter;

        public bool IsServiceAvailable()
            => _counter > 0;

        public void CountBrew()
            => _counter--;

        public void ResetBrewCounter()
            => _counter = _maxCounter;
    }
}
