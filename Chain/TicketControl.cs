public class TicketControl {
    private Handler start;
    private Handler end;

    public TicketControl(Handler start){
        this.start = start;
        this.end   = start;
    }

    public void AddNextHandler(Handler next){
       this.end.SetNext(next);
       this.end = next;
    }

    public void ProcessTicket(string request){
        this.start.Handle(request);
        Console.WriteLine("********* Fim do atendimento **********");
    }
}