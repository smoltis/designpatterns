using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The Observer Pattern
             *
             * Example:
             * A publisher creates a new magazine and begins publishing issues.
             * You subscribve and receive issues as along as you stay subscribed.
             * You can unsubscribe at any time.
             * Others can also subscribe.
             * Other can also unsubscribe.
             * If Publisher ceases business, you stop receiving issues.
             *
             * Allows:
             * -Subjests and Observers are "loosely coupled"
             * -Strive for loosely coupled designs between objects that interact. (Design Principle #4)
             *
             * Implementation (Push):
             *
             * We define 3 interfaces:
             *  -ISubject (implemented by publisher, stores the list of subscribers, notifies on updates)
             *  -IObserver (implemented by subscriber, update method)
             *  -IDisplayElement (implemented by subscriber, display method)
             *
             * We define main class WatherData:
             *  -WatherData that implements ISubject
             *  -Notifies observers(subscribers) though method Update()
             *  -This doesn't know anything about observers
             *  -Subject doesn't care it keeps doing its job
             *
             * We define subscriber classes:
             * -Each implements interfaces IObserver and IDisplayElement just to display info
             * -Each receives Subject(Publisher) in constructor, subscribes itself to it, and keeps it in private field
             * -To become an observer it needs to implement IObserver
             * 
             */

            //create concrete subject(publisher)
            WeatherData weatherData = new WeatherData();

            //create Observer(subscriber) and register with Subject(publisher)
            CurrentConditionsDisplay currentConditions = new CurrentConditionsDisplay(weatherData); //subscribe in constructor of observer(subscriber), PUSH subscription
            //create more Observers(subscribers)
            weatherData.RegisterObserver(new StatisticsDisplay(weatherData)); //subscribe in method of subject(publisher), PULL subscription

            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            //refresh data at Subject(publisher), simulate new data from sensors
            weatherData.SetMeasurements(new Data()
            {
                Temp = 80,
                Humidity = 65,
                Pressure = 29.2
            });

            weatherData.SetMeasurements(new Data()
            {
                Temp = 82,
                Humidity = 70,
                Pressure = 30.4
            });

            weatherData.SetMeasurements(new Data()
            {
                Temp = 78,
                Humidity = 90,
                Pressure = 29.4
            });

            Console.ReadLine();
        }
    }
}
