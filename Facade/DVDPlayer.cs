class DVDPlayer
{
    public void On()
    {
        Console.WriteLine("DVD Player ligado.");
    }

    public void Off()
    {
        Console.WriteLine("DVD Player desligado.");
    }

    public void Play(string movie)
    {
        Console.WriteLine($"Reproduzindo o filme: {movie}.");
    }

    public void Stop()
    {
        Console.WriteLine("Parando o filme.");
    }
}