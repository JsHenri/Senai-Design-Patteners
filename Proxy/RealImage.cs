// Classe Real: RealImage
public class RealImage : IImage
{
    private string fileName;

    public RealImage(string fileName)
    {
        this.fileName = fileName;
        LoadFromDisk();
    }

    private void LoadFromDisk()
    {
        Console.WriteLine("Carregando " + fileName);
    }

    public void Display()
    {
        Console.WriteLine("Exibindo " + fileName);
    }
}