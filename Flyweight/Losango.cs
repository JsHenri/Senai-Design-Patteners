public class Losango : IFigura
{
    private readonly string tipo;

    public Losango()
    {
        tipo = "Losango"; // Estado intrínseco
    }

    public void Desenhar(string cor)
    {
        Console.WriteLine($"Desenhando {tipo} na cor {cor}");
    }
}