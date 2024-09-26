public class CarroPopularBuilder : ICarroBuilder
{
    private Carro _carro;

    public void IniciarConstrucao(){
        _carro = new Carro();
    }

    public void DefinirModelo()
    {
        _carro.Modelo = "Carro Popular";
    }

    public void DefinirMotor()
    {
        _carro.Motor = "Motor 1.0";
    }

    public void DefinirAssentos()
    {
        _carro.Assentos = 5;
    }

    public void DefinirPortas(TipoPortas portas)
    {
        _carro.Portas = portas;
    }

    public void DefinirArCondicionado()
    {
        _carro.ArCondicionado = false;
    }

    public void DefinirComputadorDeBordo()
    {
        _carro.ComputadorDeBordo = false;
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
