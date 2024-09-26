public class Historico
{
    private Stack<Memento> _historico = new Stack<Memento>();

    // Salva o estado atual (memento) no histórico
    public void AdicionarMemento(Memento memento)
    {
        _historico.Push(memento);
    }

    // Restaura o estado anterior, se houver
    public Memento Desfazer()
    {
        if (_historico.Count > 0)
        {
            return _historico.Pop();
        }
        return null;
    }
}