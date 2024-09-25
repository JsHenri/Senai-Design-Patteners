// Classe concreta que representa uma TV
public class TV : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("TV ligada.");
    }

    public void TurnOff()
    {
        Console.WriteLine("TV desligada.");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"Volume da TV ajustado para {volume}.");
    }
}