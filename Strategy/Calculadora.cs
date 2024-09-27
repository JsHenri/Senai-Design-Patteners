public class Calculadora
{
    private IOperacao _operacao;

    // Definindo a estratégia a ser utilizada em tempo de execução
    public void DefinirOperacao(IOperacao operacao)
    {
        _operacao = operacao;
    }

    // Método que executa a operação com base na estratégia definida
    public int Calcular(int a, int b)
    {
        if (_operacao == null)
        {
            Console.WriteLine("Nenhuma operação definida.");
            return 0;
        }
        return _operacao.Executar(a, b);
    }
}
