// Criando a biblioteca
Biblioteca biblioteca = new Biblioteca();
biblioteca.AdicionarLivro(new Livro("1984", "George Orwell"));
biblioteca.AdicionarLivro(new Livro("Dom Quixote", "Miguel de Cervantes"));
biblioteca.AdicionarLivro(new Livro("O Senhor dos Anéis", "J.R.R. Tolkien"));

// Criando o iterador
IIterator<Livro> iterator = biblioteca.CreateIterator();

// Iterando sobre os livros
Console.WriteLine("Livros na biblioteca:");
while (iterator.MoveNext())
{
    Livro livro = iterator.Current;
    Console.WriteLine(livro);
}