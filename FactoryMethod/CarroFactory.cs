public class CarroFactory : VeiculoFactory
{
    public override IVeiculo CriarVeiculo()
    {
        return new Carro();
    }
}