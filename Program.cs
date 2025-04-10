using System;

class MenuPrincipal
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Escolha qual arquivo deseja rodar:");
            Console.WriteLine("1. Exercícios Prontos");
            Console.WriteLine("2. Meus Exercícios");
            Console.WriteLine("0. Sair");

            Console.Write("\nDigite sua escolha: ");
            string escolha = Console.ReadLine()!;

            switch (escolha)
            {
                case "1":
                    Ex00_Class.Run();
                    break;
                case "2":
                    Ex00.Run();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
} 