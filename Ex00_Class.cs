// Ex00: Arquivo inicial.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual exercício deseja rodar? (Ex: 1, 2, 3...)");
        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Ex01_Class.Run();
                break;
            case "2":
                Ex02_Class.Run();
                break;
            case "3":
                Ex03_Class.Run();
                break;
            case "4":
                Ex04_Class.Run();
                break;
            case "5":
                Ex05_Class.Run();
                break;
            case "6":
                Ex06_Class.Run();
                break;
            case "7":
                Ex07_Class.Run();
                break;
            case "8":
                Ex08_Class.Run();
                break;
            case "9":
                Ex09_Class.Run();
                break;
            case "10":
                Ex10_Class.Run();
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