
List<string> tarefas = new List<string>();
List<bool> concluida = new List<bool>();

bool executando = true;

while (executando)
{
    Console.Clear();
    Console.WriteLine("📝 LISTA DE TAREFAS");
    Console.WriteLine("------------------------");
    Console.WriteLine("1 - Adicionar nova tarefa");
    Console.WriteLine("2 - Marcar tarefa como concluída");
    Console.WriteLine("3 - Ver lista de tarefas");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opção: ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("\nDigite a nova tarefa: ");
            string tarefa = Console.ReadLine();
            tarefas.Add(tarefa);
            concluida.Add(false);
            Console.WriteLine("Tarefa adicionada com sucesso!");
            Console.ReadKey();
            break;

        case "2":
            if (tarefas.Count == 0)
            {
                Console.WriteLine("\nNenhuma tarefa para marcar.");
            }
            else
            {
                Console.WriteLine("\nTarefas:");
                for (int i = 0; i < tarefas.Count; i++)
                {
                    string status = concluida[i] ? "[X]" : "[ ]";
                    Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
                }

                Console.Write("\nDigite o número da tarefa concluída: ");
                if (int.TryParse(Console.ReadLine(), out int indice) &&
                    indice >= 1 && indice <= tarefas.Count)
                {
                    concluida[indice - 1] = true;
                    Console.WriteLine("Tarefa marcada como concluída!");
                }
                else
                {
                    Console.WriteLine("Número inválido.");
                }
            }
            Console.ReadKey();
            break;

        case "3":
            Console.WriteLine("\n📋 Lista de Tarefas:");
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa adicionada.");
            }
            else
            {
                for (int i = 0; i < tarefas.Count; i++)
                {
                    string status = concluida[i] ? "[X]" : "[ ]";
                    Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
                }
            }
            Console.ReadKey();
            break;

        case "4":
            executando = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            Console.ReadKey();
            break;
    }
}

Console.WriteLine("\n✅ Programa encerrado. Até a próxima!");
