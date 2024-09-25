// Classe Composite que representa um diretório
public class Directory : IComponent
{
    private string name;
    private List<IComponent> components = new List<IComponent>();

    public Directory(string name)
    {
        this.name = name;
    }

    public void Add(IComponent component)
    {
        components.Add(component);
    }

    public void Remove(IComponent component)
    {
        components.Remove(component);
    }

    public void Display(int indent=0)
    {
        Console.WriteLine(new string(' ', indent) + "Directory: " + name);
        foreach (var component in components)
        {
            component.Display(indent + 2);
        }
    }
}