public class Acucar : BebidaDecorator
{
    public Acucar(Bebida bebida) : base(bebida) { }

    public override string Descricao => _bebida.Descricao + ", Açúcar";

    public override double Custo()
    {
        return _bebida.Custo() + 0.50; // Adiciona o custo do açúcar
    }
}