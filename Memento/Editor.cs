public class Editor
{
    public string Texto { get; set; }

    // Cria um Memento com o estado atual do texto
    public Memento Salvar()
    {
        return new Memento(Texto);
    }

    // Restaura o estado a partir do Memento
    public void Restaurar(Memento memento)
    {
        Texto = memento.Texto;
    }

    public void ExibirTexto()
    {
        Console.WriteLine($"Texto atual: {Texto}");
    }
}