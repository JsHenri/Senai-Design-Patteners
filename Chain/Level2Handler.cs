public class Level2Handler : Handler {

    public override void Handle(string request)
    {
        if (request == "Problema Médio")
        {
            Console.WriteLine("Suporte médio Level 2: Resolvi o problema médio.");
        }
        else
        {
            Console.WriteLine("Suporte Médio Level 2: Não posso resolver, passando adiante.");
            Escalate(request);
        }
    }
}