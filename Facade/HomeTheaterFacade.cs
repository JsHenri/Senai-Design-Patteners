// Classe Facade
class HomeTheaterFacade
{
    private TV tv;
    private SoundSystem soundSystem;
    private DVDPlayer dvdPlayer;

    // Construtor
    public HomeTheaterFacade(TV tv, SoundSystem soundSystem, DVDPlayer dvdPlayer)
    {
        this.tv = tv;
        this.soundSystem = soundSystem;
        this.dvdPlayer = dvdPlayer;
    }

    // Método simplificado para assistir a um filme
    public void WatchMovie(string movie)
    {
        Console.WriteLine("Preparando para assistir ao filme...");
        tv.On();
        soundSystem.On();
        soundSystem.SetVolume(20);
        dvdPlayer.On();
        dvdPlayer.Play(movie);
    }

    // Método simplificado para desligar o sistema
    public void EndMovie()
    {
        Console.WriteLine("Desligando o sistema...");
        dvdPlayer.Stop();
        dvdPlayer.Off();
        soundSystem.Off();
        tv.Off();
    }
}