public class ProxyImage : IImage
{
    private RealImage realImage;
    private string fileName;

    public ProxyImage(string fileName)
    {
        this.fileName = fileName;
    }

    public void Display()
    {
        // Cria o objeto real apenas quando necessário
        if (realImage == null)
        {
            Console.WriteLine("Exibindo imagem padrão do proxy.");
            realImage = new RealImage(fileName);
        }
        realImage.Display();
    }
}