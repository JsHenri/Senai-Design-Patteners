public class Level1Handler : Handler {

    public override void Handle(string request)
    {
        if (request == "Problema Simples")
        {
            Console.WriteLine("Suporte básico Level 1: Resolvi o problema simples.");
        }
        else
        {
            Console.WriteLine("Suporte Básico Level 1: Não posso resolver, passando adiante.");
            Escalate(request);
        }
    }
}