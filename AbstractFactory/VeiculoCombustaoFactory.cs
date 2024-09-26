public class VeiculoCombustaoFactory : IVeiculoFactory
{
    public ICarro CriarCarro()
    {
        return new CarroCombustao();
    }

    public IMoto CriarMoto()
    {
        return new MotoCombustao();
    }
}