public class Level3Handler : Handler {

    public override void Handle(string request)
    {
        if (request == "Problema Avançado")
        {
            Console.WriteLine("Suporte Avançado Level 3: Resolvi o problema médio.");
        }
        else
        {
            Console.WriteLine("Suporte Avançado Level 3: Não posso resolver, passando adiante.");
            Escalate(request);
        }
    }
}