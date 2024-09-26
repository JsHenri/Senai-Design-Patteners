Editor editor = new Editor();
Historico historico = new Historico();

string opcao;

do
{
    Console.WriteLine("\nDigite o texto que deseja inserir no editor (ou 'desfazer' para restaurar): ");
    opcao = Console.ReadLine();

    if (opcao.ToLower() == "desfazer")
    {
        Memento memento = historico.Desfazer();

        if (memento != null)
        {
            editor.Restaurar(memento);
            Console.WriteLine("Desfeito! Estado anterior restaurado:");
        }
        else
        {
            Console.WriteLine("Nenhum estado anterior disponível.");
        }
    }
    else
    {
        // Salva o estado atual antes de modificar
        historico.AdicionarMemento(editor.Salvar());

        // Atualiza o texto no editor
        editor.Texto = opcao;
        Console.WriteLine("Texto atualizado:");
    }

    // Exibe o texto atual no editor
    editor.ExibirTexto();

    Console.WriteLine("\nDeseja continuar editando? (Digite 'sair' para finalizar ou pressione Enter para continuar.)");
    opcao = Console.ReadLine();
}
while (opcao.ToLower() != "sair");

Console.WriteLine("Edição encerrada.");
