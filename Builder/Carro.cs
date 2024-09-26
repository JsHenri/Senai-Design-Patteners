public class Carro
{
    public string Modelo { get; set; }
    public string Motor { get; set; }
    public int Assentos { get; set; }
    public TipoPortas Portas { get; set; } // Usando o enum aqui
    public bool ArCondicionado { get; set; }
    public bool ComputadorDeBordo { get; set; }
    public List<string> Opcionais { get; set; } = new List<string>();

    public override string ToString()
    {
        return $"Carro Modelo: {Modelo}, Motor: {Motor}, Assentos: {Assentos}, Portas: {(int)Portas}, Ar Condicionado: {ArCondicionado}, Computador de Bordo: {ComputadorDeBordo}, Opcionais: {string.Join(", ", Opcionais)}";
    }
}
