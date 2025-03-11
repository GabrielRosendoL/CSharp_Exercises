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
                Ex01.Run();
                break;
            case "2":
                Ex02.Run();
                break;
            case "3":
                Ex03.Run();
                break;
            case "4":
                Ex04.Run();
                break;
            case "5":
                Ex05.Run();
                break;
            case "6":
                Ex06.Run();
                break;
            case "7":
                Ex07.Run();
                break;
            case "8":
                Ex08.Run();
                break;
            case "9":
                Ex09.Run();
                break;
            default:
                Console.WriteLine("Exercício não encontrado.");
                break;
        }
    }
}

// NOTA I: O "Main" é o primeiro método que é executado quando o programa é rodado.

// NOTA II: O " public static void Run()" é um método que executa o código do exercício.