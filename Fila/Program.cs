using Fila;
using System.Reflection.PortableExecutable;


Console.WriteLine("Escolha uma opção:\n1 - Inserir Pessoa\n2 - Remover Pessoa" +
    "\n3 - Tamanho da Fila\n4 - Exibir a Fila");
int opcao = int.Parse(Console.ReadLine()!);

FilaClass f = new FilaClass();

switch (opcao)
{
    case 1:
        Console.WriteLine("Digite o nome da pessoa que deseja adicionar:");
        string nome = Console.ReadLine()!;
        f.InserirPessoa(new Pessoa { Nome = nome });
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

