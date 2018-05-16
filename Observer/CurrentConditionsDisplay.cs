using System;

namespace Observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private IData _data;
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this); //subscribe itself, Subject(publisher) will add this instance to its list
        }
        public void Update(IData data) //receives new data
        {
            _data = data;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current: {_data.Temp} F degrees and {_data.Humidity} % humidity"); //we don't want to show pressure here
        }
    }
}