public class AreaVisitor : IVisitor
{
    public void Visit(Circulo circulo)
    {
        double area = Math.PI * Math.Pow(circulo.Raio, 2);
        Console.WriteLine($"Área do círculo: {area}");
    }

    public void Visit(Retangulo retangulo)
    {
        double area = retangulo.Largura * retangulo.Altura;
        Console.WriteLine($"Área do retângulo: {area}");
    }
}