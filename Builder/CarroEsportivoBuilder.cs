public class CarroEsportivoBuilder : ICarroBuilder
{
    private Carro _carro = new Carro();

    public void DefinirModelo()
    {
        _carro.Modelo = "Carro Esportivo";
    }

    public void DefinirMotor()
    {
        _carro.Motor = "Motor V8";
    }

    public void DefinirAssentos()
    {
        _carro.Assentos = 2;
    }

    public void DefinirPortas(TipoPortas portas)
    {
        _carro.Portas = portas;
    }

    public void DefinirArCondicionado()
    {
        _carro.ArCondicionado = true;
    }

    public void DefinirComputadorDeBordo()
    {
        _carro.ComputadorDeBordo = true;
    }

    public void AdicionarOpcional(string opcional)
    {
        _carro.Opcionais.Add(opcional);
    }

    public Carro ObterCarro()
    {
        return _carro;
    }
}
