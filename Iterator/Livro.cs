public class Livro
{
    public string Titulo { get; }
    public string Autor { get; }

    public Livro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public override string ToString()
    {
        return $"{Titulo} por {Autor}";
    }
}
