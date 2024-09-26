public class Quadrado : IFigura
{
    private readonly string tipo;

    public Quadrado()
    {
        tipo = "Quadrado"; // Estado intrínseco
    }

    public void Desenhar(string cor)
    {
        Console.WriteLine($"Desenhando {tipo} na cor {cor}");
    }
}