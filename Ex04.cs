// Exercício 4: Calculando a média de três números

class Ex04 
{
    public static void Run()
    {
        Console.WriteLine("Digite o primeiro número:");
        string? input1 = Console.ReadLine();

        Console.WriteLine("Digite o segundo número:");
        string? input2 = Console.ReadLine();

        Console.WriteLine("Digite o terceiro número:");
        string? input3 = Console.ReadLine();

        
        if (input1 != null && input2 != null && input3 != null) 
        {
            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);
            int num3 = int.Parse(input3);
            
            double media = (num1 + num2 + num3) / 3.0;

            Console.WriteLine("A média é " + media);
        } 
            
        else 
        {
            Console.WriteLine("Uma ou mais entradas foram inválidas.");
        }
    }
}

