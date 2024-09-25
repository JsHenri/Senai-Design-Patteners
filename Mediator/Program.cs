// Criando o mediador
ChatMediator mediator = new ChatMediator();

// Criando os usuários (colegas) e registrando-os no mediador
Manager m1 = new Manager(mediator, "João");
Employee e1 = new Employee(mediator, "Ana");
Employee e2 = new Employee(mediator, "Marco");

mediator.AddColleague(m1);
mediator.AddColleague(e1);
mediator.AddColleague(e2);

// Enviando mensagens
m1.Send("Olá, temos que melhor o nosso desempenho!");
e1.Send("Sim, chefe. Estamos trabalhando nisso");