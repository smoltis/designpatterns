namespace Observer
{
    public interface ISubject //Subject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}