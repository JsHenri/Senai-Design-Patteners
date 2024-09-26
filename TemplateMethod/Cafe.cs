public class Cafe : BebidaQuente
{
    protected override void PrepararBebida()
    {
        Console.WriteLine("Preparando o café...");
    }

    protected override void AdicionarComplementos()
    {
        Console.WriteLine("Adicionando açúcar e leite...");
    }
}