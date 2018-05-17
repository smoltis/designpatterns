using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

namespace Observer
{
    public class WeatherData : ISubject //concrete subject
    {
        private readonly List<IObserver> _observers; //we'll maintain this list of subscribers

        private IData _data;

        public WeatherData()
        {
            _observers = new List<IObserver>();
            _data = new Data();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            _observers.ForEach( a => a.Update(_data));
        }

        public void SetMeasurements(IData data)
        {
            _data = data;
            MeasurementsChanged();
        }
        //just in case we need to take differnt action on measurements changed we create this method
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public IData GetData()
        {
            return _data;
        }
    }
}