using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Integration
{
    public interface IWeatherService
    {
        double GetCurrentTemperature(double longitude, double latitude);
    }

    public class MockWeatherService : IWeatherService
    {
        private static readonly Random _random = new();

        public double GetCurrentTemperature(double longitude, double latitude) 
            => (_random.NextDouble() * (45 - (-20))) + (-20);
    }
}
