// Criando o receptor
Luz luz = new Luz();

// Criando os comandos
ICommand ligarLuz = new LigarLuzCommand(luz);
ICommand desligarLuz = new DesligarLuzCommand(luz);

// Criando o invocador
ControleRemoto controle = new ControleRemoto();

// Configurando o comando para ligar a luz
controle.DefinirComando(ligarLuz);
controle.PressionarBotao();

// Configurando o comando para desligar a luz
controle.DefinirComando(desligarLuz);
controle.PressionarBotao();

// Desfazendo a última operação (Desligar)
controle.PressionarBotaoDesfazer();
controle.PressionarBotaoDesfazer();