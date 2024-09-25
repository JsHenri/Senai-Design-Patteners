// Classe concreta Colleague: User1
public class Manager : Colleague
{
    public Manager(IMediator mediator, string name) : base(mediator, name) { }


    public override void Notify(string message)
    {
        Console.WriteLine($"{this.GetType().Name} {name} recebeu mensagem: {message}");    
    }
}