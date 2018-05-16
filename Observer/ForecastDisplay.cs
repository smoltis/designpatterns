using System;

namespace Observer
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private double _currentPressure = 29.2;
        private double _lastPressure;

        public ForecastDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(IData data)
        {
            _lastPressure = _currentPressure;
            _currentPressure = data.Pressure;
            Display();
        }

        public void Display()
        {
            if (_currentPressure > _lastPressure) Console.WriteLine("Improving weather on the way!");
            else if (Math.Abs(_currentPressure - _lastPressure) < 0.5 ) Console.WriteLine("More of the same");
            else if (_currentPressure < _lastPressure) Console.WriteLine("Watch out for cooler, rainy weather");
            Console.WriteLine($"");
        }
    }
}