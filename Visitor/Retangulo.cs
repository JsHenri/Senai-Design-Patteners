public class Retangulo : IForma
{
    public double Largura { get; }
    public double Altura { get; }

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public void Aceitar(IVisitor visitor)
    {
        visitor.Visit(this);  // Chama o método Visit específico para Retângulo
    }
}