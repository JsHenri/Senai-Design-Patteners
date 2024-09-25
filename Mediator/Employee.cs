public class Employee : Colleague
{
    public Employee(IMediator mediator, string name) : base(mediator,name) { }


    public override void Notify(string message)
    {
        Console.WriteLine($"{this.GetType().Name}  {name} recebeu mensagem: {message}");
    }
}