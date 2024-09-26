public abstract class Handler : IHandler
{
    private IHandler nextHandler;

    public void SetNext(IHandler handler)
    {
        this.nextHandler = handler;
    }

    public bool HasNextHandler(){
        return this.nextHandler != null;
    }

    public abstract void Handle(string request);
        
    public void Escalate(string request)
    {
        if (HasNextHandler()) {
            this.nextHandler.Handle(request);
        }
        else {
            Console.WriteLine("Fim de linha: Ninguém pode resolver!");
        }
    }
}