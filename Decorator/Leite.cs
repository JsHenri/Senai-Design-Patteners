public class Leite : BebidaDecorator
{
    public Leite(Bebida bebida) : base(bebida) { }

    public override string Descricao => _bebida.Descricao + ", Leite";

    public override double Custo()
    {
        return _bebida.Custo() + 1.50; // Adiciona o custo do leite
    }
}