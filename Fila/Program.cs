using Fila;
using System.Reflection.PortableExecutable;


Console.WriteLine("Escolha uma opção:\n1 - Inserir Pessoa\n2 - Remover Pessoa" +
    "\n3 - Tamanho da Fila\n4 - Exibir a Fila");
int opcao = int.Parse(Console.ReadLine()!);

FilaClass f = new FilaClass();
Pessoa head = new Pessoa();
Pessoa tail = new Pessoa();
Pessoa pessoa = new Pessoa();

switch (opcao)
{
    case 1:
        Console.WriteLine("Digite o nome da pessoa que deseja adicionar:");
        pessoa.Nome = Console.ReadLine()!;
        f.InserirPessoa(pessoa, head, tail);
        break;
    case 2:
        Console.WriteLine("Digite o nome da pessoa que deseja remover");
        pessoa.Nome = Console.ReadLine()!;
        f.RemoverPessoa(head, tail);
        break;
    case 3:
        f.TamanhoFila(head);
        break;
    case 4:
        f.ImprimirFila(head);
        break;
    default:
        break;
}

