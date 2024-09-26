public class MotoFactory : VeiculoFactory
{
    public override IVeiculo CriarVeiculo()
    {
        return new Moto();
    }
}