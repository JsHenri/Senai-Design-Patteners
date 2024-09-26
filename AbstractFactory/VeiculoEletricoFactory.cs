public class VeiculoEletricoFactory : IVeiculoFactory
{
    public ICarro CriarCarro()
    {
        return new CarroEletrico();
    }

    public IMoto CriarMoto()
    {
        return new MotoEletrica();
    }
}