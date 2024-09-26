public class Director
{
    private ICarroBuilder _builder;

    public Director(ICarroBuilder builder)
    {
        _builder = builder;
    }

    public void ConstruirCarro(TipoPortas portas, params string[] opcionais)
    {
        _builder.DefinirModelo();
        _builder.DefinirMotor();
        _builder.DefinirAssentos();
        _builder.DefinirArCondicionado();
        _builder.DefinirComputadorDeBordo();
        _builder.DefinirPortas(portas);

        foreach (var op in opcionais)
        {
            _builder.AdicionarOpcional(op);
        }
    }

    public Carro ObterCarro()
    {
        return _builder.ObterCarro();
    }
}