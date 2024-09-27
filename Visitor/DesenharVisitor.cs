// Visitante que desenha formas
public class DesenharVisitor : IVisitor
{
    public void Visit(Circulo circulo)
    {
        Console.WriteLine($"Desenhando um círculo com raio: {circulo.Raio}");
    }

    public void Visit(Retangulo retangulo)
    {
        Console.WriteLine($"Desenhando um retângulo com largura: {retangulo.Largura} e altura: {retangulo.Altura}");
    }
}