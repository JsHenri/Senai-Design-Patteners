// Classe concreta Subject
public class Store : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private string productName;
    private string availability;

    public Store(string productName, string availability)
    {
        this.productName = productName;
        this.availability = availability;
    }

    public string GetAvailability()
    {
        return availability;
    }

    public void SetAvailability(string availability)
    {
        this.availability = availability;
        NotifyObservers();
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(availability);
        }
    }
}
