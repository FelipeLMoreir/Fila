using FilaBanco;

Console.WriteLine("Fila dos bancos!");
Banco banco = new Banco();

int opcao;

void MostrarFila()
{
    Console.WriteLine("Fila Prioritária");
    banco.FilaPrioritaria.MostrarFila();
    Console.WriteLine("Fila Normal");
    banco.FilaNormal.MostrarFila();
    Console.ReadLine();
}

do
{

    Console.WriteLine("Escolha uma opção:\n1 - Adicionar Cliente" +
        "\n2 - Atender o próximo cliente" +
        "\n3 - Exibir a Fila\n0 - Sair");
    opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite o nome da pessoa que deseja adicionar:");
            string nome = Console.ReadLine()!;
            Console.WriteLine("Digite a idade da pessoa que deseja adicionar:");
            int idade = int.Parse(Console.ReadLine()!);

            Cliente c = new(nome, idade);
            if (c.EhPrioritario)
            {
                banco.FilaPrioritaria.Enfileirar(c);
            }
            else
            {
                banco.FilaNormal.Enfileirar(c);
            }
            MostrarFila();
            Console.Clear();
            break;
        case 2:
            c = banco.AtenderCliente();
            if (c is null)
            {
                Console.WriteLine("Nenhum cliente na fila");
            }
            else
            {
                Console.WriteLine(c.ToString());
            }
            MostrarFila();
            Console.Clear();
            break;
        case 3:
            MostrarFila();
            Console.Clear();
            break;
        default:
            break;
    }

} while (opcao != 0);