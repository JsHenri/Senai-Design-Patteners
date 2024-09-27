public class SemMoeda : IEstadoMaquina
{
    private MaquinaVenda _maquina;

    public SemMoeda(MaquinaVenda maquina)
    {
        _maquina = maquina;
    }

    public void InserirMoeda()
    {
        Console.WriteLine("Moeda inserida.");
        _maquina.DefinirEstado(_maquina.MoedaInserida);
    }

    public void EjetarMoeda()
    {
        Console.WriteLine("Nenhuma moeda inserida.");
    }

    public void SelecionarProduto()
    {
        Console.WriteLine("Você precisa inserir uma moeda primeiro.");
    }

    public void DespacharProduto()
    {
        Console.WriteLine("Você precisa pagar antes.");
    }
}
