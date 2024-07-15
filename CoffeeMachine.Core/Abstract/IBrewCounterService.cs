namespace CoffeeMachine.Core.Abstract
{
    public interface IBrewCounterService
    {
        void CountBrew();
        bool IsServiceAvailable();
        void ResetBrewCounter();
    }
}
