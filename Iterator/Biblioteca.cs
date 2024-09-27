public class Biblioteca : IAggregate<Livro>
{
    private List<Livro> _livros = new List<Livro>();

    public void AdicionarLivro(Livro livro)
    {
        _livros.Add(livro);
    }

    public IIterator<Livro> CreateIterator()
    {
        return new BibliotecaIterator(_livros);
    }
}
