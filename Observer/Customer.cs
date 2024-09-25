// Classe concreta Observer
public class Customer : IObserver
{
    private string customerName;

    public Customer(string name)
    {
        this.customerName = name;
    }

    public void Update(string availability)
    {
        Console.WriteLine($"Notificação para {customerName}: O produto está agora {availability}");
    }
}