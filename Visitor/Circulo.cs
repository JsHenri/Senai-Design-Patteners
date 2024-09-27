public class Circulo : IForma
{
    public double Raio { get; }

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public void Aceitar(IVisitor visitor)
    {
        visitor.Visit(this);  // Chama o método Visit específico para Círculo
    }
}