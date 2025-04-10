// Exercício 01 - Classes: Trabalhando com Classes e Métodos
// Complete o código abaixo seguindo as instruções nos comentários

using System;

// TODO: Crie uma classe chamada 'Calculadora' que terá métodos para operações matemáticas básicas
// A classe deve ter os seguintes métodos:
// - Soma: recebe dois números e retorna a soma
// - Subtracao: recebe dois números e retorna a subtração
// - Multiplicacao: recebe dois números e retorna a multiplicação
// - Divisao: recebe dois números e retorna a divisão

class Ex01Class
{
    public static void Run()
    {
        try
        {
            Console.WriteLine("Calculadora Básica");
            Console.WriteLine("=================");

            // TODO: Crie uma instância da classe Calculadora aqui
            // Exemplo: Calculadora calc = new Calculadora();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Soma");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Sair");

                Console.Write("\nEscolha uma operação: ");
                string opcao = Console.ReadLine()!;

                if (opcao == "5")
                    break;

                Console.Write("Digite o primeiro número: ");
                // TODO: Leia o primeiro número e converta para double
                // Dica: Use double.Parse() ou double.TryParse()

                Console.Write("Digite o segundo número: ");
                // TODO: Leia o segundo número e converta para double

                double resultado = 0;

                // TODO: Use a instância da Calculadora para realizar a operação escolhida
                // e armazene o resultado na variável 'resultado'
                // Use um switch para escolher a operação correta

                Console.WriteLine($"Resultado: {resultado}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}

// NOTA I: Lembre-se de tratar possíveis erros, especialmente na divisão por zero
// NOTA II: Use o método TryParse para converter strings em números de forma segura
// NOTA III: Todos os métodos da classe Calculadora devem ser públicos
// NOTA IV: A classe Calculadora não precisa de propriedades, apenas métodos 