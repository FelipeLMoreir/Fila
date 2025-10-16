using Fila;
using System.Reflection.PortableExecutable;

int opcao;
FilaClass f = new FilaClass();

do
{

    Console.WriteLine("Escolha uma opção:\n1 - Inserir Pessoa\n2 - Remover Pessoa" +
        "\n3 - Tamanho da Fila\n4 - Exibir a Fila\n0 - Sair");
    opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite o nome da pessoa que deseja adicionar:");
            string nome = Console.ReadLine()!;
            f.InserirPessoa(new Pessoa { Nome = nome });
            Console.Clear();
            break;
        case 2:
            f.RemoverPessoa();
            break;
        case 3:
            f.TamanhoFila();
            break;
        case 4:
            f.ImprimirFila();
            break;
        default:
            break;
    }
    
} while (opcao != 0);
