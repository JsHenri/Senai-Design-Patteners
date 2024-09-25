public class Singleton
{
    // A instância privada e estática da classe
    private static Singleton instance;

    // Um objeto para sincronização
    private static readonly object lockObject = new object();

    // Construtor privado para evitar instanciamento externo
    private Singleton()
    {
        // Inicialização da instância
    }

    // Propriedade pública para obter a instância
    public static Singleton Instance
    {
        get
        {
            // Usa bloqueio para garantir que apenas uma instância seja criada em ambientes multithread
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }

    // Um exemplo de método da classe
    public void ShowMessage()
    {
        Console.WriteLine("Hello from Singleton!");
    }
}
