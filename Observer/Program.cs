// Criando o Subject (Loja)
Store store = new Store("PlayStation 5", "Indisponível");

// Criando Observers (Clientes)
Customer customer1 = new Customer("Maria");
Customer customer2 = new Customer("João");

// Registrando os clientes como observadores da loja
store.RegisterObserver(customer1);
store.RegisterObserver(customer2);

// Alterando a disponibilidade do produto
Console.WriteLine("Alterando a disponibilidade do produto para 'Disponível'.");
store.SetAvailability("Disponível");

// Desregistrando um cliente e mudando a disponibilidade novamente
store.RemoveObserver(customer1);
Console.WriteLine("\nAlterando a disponibilidade do produto para 'Indisponível'.");
store.SetAvailability("Indisponível");