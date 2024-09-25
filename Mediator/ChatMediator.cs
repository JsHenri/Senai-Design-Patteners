// Classe concreta Mediator
public class ChatMediator : IMediator
{
    private List<Colleague> colleagues = new List<Colleague>();

    public void AddColleague(Colleague colleague)
    {
        colleagues.Add(colleague);
    }

    public void SendMessage(string message, Colleague sender)
    {
        foreach (var colleague in colleagues)
        {
            if (colleague != sender)
            {
                colleague.Notify(message);
            }
        }
        Console.WriteLine("******* Fim mensagem ***********");
    }
}
