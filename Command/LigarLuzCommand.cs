public class LigarLuzCommand : ICommand
{
    private Luz _luz;

    public LigarLuzCommand(Luz luz)
    {
        _luz = luz;
    }

    public void Executar()
    {
        _luz.Ligar();
    }

    public void Desfazer()
    {
        _luz.Desligar();
    }
}
