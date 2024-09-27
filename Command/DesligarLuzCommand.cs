public class DesligarLuzCommand : ICommand
{
    private Luz _luz;

    public DesligarLuzCommand(Luz luz)
    {
        _luz = luz;
    }

    public void Executar()
    {
        _luz.Desligar();
    }

    public void Desfazer()
    {
        _luz.Ligar();
    }
}
