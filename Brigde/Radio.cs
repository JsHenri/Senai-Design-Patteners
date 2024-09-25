// Classe concreta que representa um Rádio
public class Radio : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Rádio ligado.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Rádio desligado.");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"Volume do rádio ajustado para {volume}.");
    }
}