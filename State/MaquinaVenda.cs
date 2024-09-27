public class MaquinaVenda
{
    public IEstadoMaquina SemMoeda { get; }
    public IEstadoMaquina MoedaInserida { get; }
    public IEstadoMaquina ProdutoSelecionado { get; }

    private IEstadoMaquina _estadoAtual;

    public MaquinaVenda()
    {
        SemMoeda = new SemMoeda(this);
        MoedaInserida = new MoedaInserida(this);
        ProdutoSelecionado = new ProdutoSelecionado(this);

        // Estado inicial
        _estadoAtual = SemMoeda;
    }

    public void DefinirEstado(IEstadoMaquina novoEstado)
    {
        _estadoAtual = novoEstado;
    }

    public void InserirMoeda()
    {
        _estadoAtual.InserirMoeda();
    }

    public void EjetarMoeda()
    {
        _estadoAtual.EjetarMoeda();
    }

    public void SelecionarProduto()
    {
        _estadoAtual.SelecionarProduto();
    }

    public void DespacharProduto()
    {
        _estadoAtual.DespacharProduto();
    }
}
