using System;

namespace Observer
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private double _minT = 200;
        private double _maxT = 0.0;
        private double _sumT = 0.0;
        private int _numReadings;

        public StatisticsDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(IData data)
        {
            _sumT += data.Temp;
            if (data.Temp > _maxT) _maxT = data.Temp;
            if (data.Temp < _minT) _minT = data.Temp;
            _numReadings++;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Max/Min/Avg Temperature: {_maxT}/{_minT}/{_sumT/_numReadings}");
        }
    }
}