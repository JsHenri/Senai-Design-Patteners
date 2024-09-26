public class FlyweightFactory
{
    private readonly Dictionary<string, IFigura> _figuras = new Dictionary<string, IFigura>();

    public IFigura GetFigura(string tipo)
    {
        if (!_figuras.ContainsKey(tipo))
        {
            switch (tipo)
            {
                case "Triangulo":
                    Console.WriteLine("Criando um novo triângulo");
                    _figuras[tipo] = new Triangulo();
                    break;
                case "Quadrado":
                    Console.WriteLine("Criando um novo quadrado");
                    _figuras[tipo] = new Quadrado();
                    break;
                case "Losango":
                    Console.WriteLine("Criando um novo losango");
                    _figuras[tipo] = new Losango();
                    break;
                default:
                    throw new Exception("Figura desconhecida.");
            }
        }

        return _figuras[tipo];
    }
}