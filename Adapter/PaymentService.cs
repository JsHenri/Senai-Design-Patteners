// Classe que processa pagamentos utilizando a interface existente
public class PaymentService
{
    private readonly IPaymentProcessor _paymentProcessor;

    public PaymentService(IPaymentProcessor paymentProcessor)
    {
        _paymentProcessor = paymentProcessor;
    }

    public void MakePayment(decimal amount)
    {
        _paymentProcessor.ProcessPayment(amount);
    }
}