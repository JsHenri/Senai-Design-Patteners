public class Divisao : IOperacao
{
    public int Executar(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Erro: Divisão por zero.");
            return 0;
        }
        return a / b;
    }
}
