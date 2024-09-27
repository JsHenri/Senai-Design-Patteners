public class BibliotecaIterator : IIterator<Livro>
{
    private readonly List<Livro> _livros;
    private int _posicaoAtual = -1;

    public BibliotecaIterator(List<Livro> livros)
    {
        _livros = livros;
    }

    public Livro Current
    {
        get
        {
            if (_posicaoAtual < 0 || _posicaoAtual >= _livros.Count)
            {
                throw new InvalidOperationException();
            }
            return _livros[_posicaoAtual];
        }
    }

    public bool MoveNext()
    {
        if (_posicaoAtual < _livros.Count - 1)
        {
            _posicaoAtual++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _posicaoAtual = -1;
    }
}
