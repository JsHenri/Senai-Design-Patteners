public abstract class Colleague
{
    public string name;

    protected IMediator mediator;

    public Colleague(IMediator mediator, string name)
    {
        this.mediator = mediator;
        this.name = name;
    }
    public void Send(string message)
    {
        Console.WriteLine($"{this.GetType().Name} {name} enviando mensagem: {message}");
        mediator.SendMessage(message, this);
    }
    
    public abstract void Notify(string message);
}