public class ProdutoSelecionado : IEstadoMaquina
{
    private MaquinaVenda _maquina;

    public ProdutoSelecionado(MaquinaVenda maquina)
    {
        _maquina = maquina;
    }

    public void InserirMoeda()
    {
        Console.WriteLine("Produto já selecionado. Despachando produto.");
    }

    public void EjetarMoeda()
    {
        Console.WriteLine("Moeda já utilizada, não pode ser devolvida.");
    }

    public void SelecionarProduto()
    {
        Console.WriteLine("Produto já selecionado.");
    }

    public void DespacharProduto()
    {
        Console.WriteLine("Produto despachado.");
        _maquina.DefinirEstado(_maquina.SemMoeda);
    }
}
