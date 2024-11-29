// Instanciando o serviço externo
ExternalPaymentService externalService = new ExternalPaymentService();

EsternalBitcoinService externalBitcoinService = new externalBitcoinService();

// Criando o adapter para permitir o uso do serviço externo
IPaymentProcessor paymentProcessor = new ExternalPaymentAdapter(externalService);
IPaymentProcessor bitcoinProcessor = new ExternalBitcoinAdapter(externalBitcoinService);

// Usando o serviço de pagamento com o adapter
PaymentService paymentService = new PaymentService(paymentProcessor);
PaymentService bitcoinPaymentService = new PaymentService(bitcoinProcessor);

paymentService.MakePayment(150.00M);
bitcoinPaymentService.MakePayment(150.00M);