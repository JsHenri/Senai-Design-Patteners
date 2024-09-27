MaquinaVenda maquina = new MaquinaVenda();

Console.WriteLine("Tentando selecionar produto sem moeda:");
maquina.SelecionarProduto(); // Não pode selecionar produto sem moeda

Console.WriteLine("\nInserindo moeda:");
maquina.InserirMoeda(); // Inserindo moeda

Console.WriteLine("\nTentando selecionar produto:");
maquina.SelecionarProduto(); // Produto selecionado

Console.WriteLine("\nDespachando produto:");
maquina.DespacharProduto(); // Produto despachado

Console.WriteLine("\nTentando ejetar moeda após despachar:");
maquina.EjetarMoeda(); // Não pode ejetar moeda após produto ser despachado
