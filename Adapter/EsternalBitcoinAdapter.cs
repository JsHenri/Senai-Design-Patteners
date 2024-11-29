public class ExternalBitcoinAdapter : IPaymentProcessor
{
    private readonly ExternalBitcoinService _externalBitcoinService;

    public ExternalBitcoinAdapter(ExternalBitcoinService externalBiticoinService)
    {
        _externalBitcoinService = externalBiticoinService;
    }

    public void ProcessPayment(decimal amount)
    {
        _externalBitcoinService.transferToWallet(amount);
    }
}