public class Director
{
    private readonly Dictionary<string, ICarroBuilder> _builders = new Dictionary<string, ICarroBuilder>();
    private ICarroBuilder builder;


    public void ConstruirCarro(string tipo, TipoPortas portas, params string[] opcionais)
    {
        try{
            
            this.builder = _builders[tipo];
            this.builder.IniciarConstrucao();
            this.builder.DefinirModelo();
            this.builder.DefinirMotor();
            this.builder.DefinirAssentos();
            this.builder.DefinirArCondicionado();
            this.builder.DefinirComputadorDeBordo();
            this.builder.DefinirPortas(portas);

            foreach (var op in opcionais)
            {
                this.builder.AdicionarOpcional(op);
            }
        }
        catch(KeyNotFoundException e)
        {
            Console.WriteLine("Não sei construir esse tipo");
        }

    }

    public void AddBuilder(string name, ICarroBuilder builder){
        this._builders[name]=builder;
    }

    public Carro ObterCarro()
    {
        return this.builder.ObterCarro();
    }
}