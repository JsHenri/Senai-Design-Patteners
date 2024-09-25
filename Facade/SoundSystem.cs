class SoundSystem
{
    public void On()
    {
        Console.WriteLine("Sistema de som ligado.");
    }

    public void Off()
    {
        Console.WriteLine("Sistema de som desligado.");
    }

    public void SetVolume(int level)
    {
        Console.WriteLine($"Volume do sistema de som ajustado para {level}.");
    }
}