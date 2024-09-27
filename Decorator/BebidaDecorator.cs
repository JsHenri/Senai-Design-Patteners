public abstract class BebidaDecorator : Bebida
{
    protected Bebida _bebida;

    public BebidaDecorator(Bebida bebida)
    {
        _bebida = bebida;
    }

    public override string Descricao => _bebida.Descricao;
    public override double Custo() => _bebida.Custo();
}
