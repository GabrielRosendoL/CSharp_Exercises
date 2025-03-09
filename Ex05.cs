// Exercício 5: Calculando o fatorial de um número

class Ex05
{

    public static void Run()
    {

        int num = 5;

        int factorial = 1;

        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("O fatorial de " + num + " é " + factorial);
    }
}

// NOTA I: O fatorial de um número é o produto de todos os inteiros positivos de 1 até o número.
// Por exemplo, o fatorial de 5 (5!) é 5 * 4 * 3 * 2 * 1 = 120.

// NOTA II: A variável 'num' armazena o número para o qual queremos calcular o fatorial.
// Neste exemplo, estamos calculando o fatorial de 5.

// NOTA III: A variável 'factorial' é inicializada com 1 porque a multiplicação por 1 não altera o resultado.
// Ela será usada para armazenar o resultado do cálculo do fatorial.

// NOTA IV: O loop 'for' começa com 'i' igual a 1 [int i = 1]
// e continua [i++] até 'i' ser igual a 'num' [i <= num].

// NOTA V: Em cada iteração, o valor de 'i' é multiplicado pelo valor atual de 'factorial' e 
// o resultado é armazenado em 'factorial'.
// Ou seja, escrever [factorial *= i] é o mesmo que escrever [factorial = factorial * i].
