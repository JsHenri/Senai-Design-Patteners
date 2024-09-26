public class Triangulo : IFigura
{
    private readonly string tipo;

    public Triangulo()
    {
        tipo = "Triângulo"; // Estado intrínseco
    }

    public void Desenhar(string cor)
    {
        Console.WriteLine($"Desenhando {tipo} na cor {cor}");
    }
}