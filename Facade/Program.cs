class Program
{
    static void Main(string[] args)
    {
        // Criando os componentes do home theater
        TV tv = new TV();
        SoundSystem soundSystem = new SoundSystem();
        DVDPlayer dvdPlayer = new DVDPlayer();

        // Criando a facade que encapsula os componentes
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(tv, soundSystem, dvdPlayer);

        // Assistir a um filme através da facade
        homeTheater.WatchMovie("O Senhor dos Anéis");

        // Desligar o sistema através da facade
        homeTheater.EndMovie();
    }
}