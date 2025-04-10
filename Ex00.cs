// Ex00: Arquivo inicial.

using System;

class Ex00
{
    public static void Run()
    {
        Console.WriteLine("Qual exercício deseja rodar? (Ex: 1, 2, 3...)");
        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Ex01.Run();
                break;
            default:
                Console.WriteLine("Exercício não encontrado.");
                break;
        }
    }
}

// NOTA I: O "Main" é o primeiro método que é executado quando o programa é rodado.

// NOTA II: O " public static void Run()" é um método que executa o código do exercício.

// NOTA III Para rodar esse código no terminal executamos o comando "dotnet run".
// O comando "dotnet run" compila e executa o código C# no terminal.