using System;

namespace Observer
{
    public class StatisticsDisplay : IObserver, IDisplayElement //Concrete Observer
    {
        private double _minT = 200;
        private double _maxT = 0.0;
        private double _sumT = 0.0;
        private int _numReadings;
        WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData) //pull observer
        {
            this.weatherData = weatherData;
        }

        public void Update(IData data) //keep this just because we have mixed push/pull methods in one project
        {
            data = weatherData.GetData(); //pull data from subject
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