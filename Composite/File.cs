// Classe Leaf que representa um arquivo
public class File : IComponent
{
    private string name;

    public File(string name)
    {
        this.name = name;
    }

    public void Display(int indent)
    {
        Console.WriteLine(new string(' ', indent) + "File: " + name);
    }
}