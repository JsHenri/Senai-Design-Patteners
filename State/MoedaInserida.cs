public class MoedaInserida : IEstadoMaquina
{
    private MaquinaVenda _maquina;

    public MoedaInserida(MaquinaVenda maquina)
    {
        _maquina = maquina;
    }

    public void InserirMoeda()
    {
        Console.WriteLine("Moeda já inserida.");
    }

    public void EjetarMoeda()
    {
        Console.WriteLine("Moeda devolvida.");
        _maquina.DefinirEstado(_maquina.SemMoeda);
    }

    public void SelecionarProduto()
    {
        Console.WriteLine("Produto selecionado.");
        _maquina.DefinirEstado(_maquina.ProdutoSelecionado);
    }

    public void DespacharProduto()
    {
        Console.WriteLine("Selecione um produto antes.");
    }
}
