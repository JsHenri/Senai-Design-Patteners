public class Cha : BebidaQuente
{
    protected override void PrepararBebida()
    {
        Console.WriteLine("Preparando o chá...");
    }

    protected override void AdicionarComplementos()
    {
        Console.WriteLine("Adicionando limão...");
    }
}
