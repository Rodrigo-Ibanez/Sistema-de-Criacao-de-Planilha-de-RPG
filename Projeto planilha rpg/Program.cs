using Projeto_planilha_rpg.Models;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Vamos começar a fazer a planilha de personagem:");

Classe rpg = new Classe();

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Digite o nome do personagem");
    Console.WriteLine("2 - Digite a Classe do personagem");
    Console.WriteLine("3 - Mostrar planilha completa");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            rpg.nomeDoPersonagem();
            break;

        case "2":
            rpg.classeDoPersonagem();
            break;

        case "3":
            rpg.mostrarPlanilha();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");

