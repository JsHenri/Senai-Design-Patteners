public interface ICarroBuilder
{

    void IniciarConstrucao();
    void DefinirModelo();
    void DefinirMotor();
    void DefinirAssentos();
    void DefinirPortas(TipoPortas portas); // Usando enum aqui
    void DefinirArCondicionado();
    void DefinirComputadorDeBordo();
    void AdicionarOpcional(string opcional);
    Carro ObterCarro();
}
