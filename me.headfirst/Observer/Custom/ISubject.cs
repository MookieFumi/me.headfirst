namespace me.headfirst.Observer.Custom
{
    public interface ISubject
    {
        void NotifyObservers();
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
    }
}