public class ControleRemoto
{
    private ICommand _comando;

    // Define o comando
    public void DefinirComando(ICommand comando)
    {
        _comando = comando;
    }

    // Executa o comando
    public void PressionarBotao()
    {
        _comando.Executar();
    }

    // Desfaz o último comando
    public void PressionarBotaoDesfazer()
    {
        _comando.Desfazer();
    }
}
