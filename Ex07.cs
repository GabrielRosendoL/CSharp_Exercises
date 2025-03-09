// Exercício 7: Calculando a soma dos primeiros 30 números ímpares

class Ex07
{
    public static void Run()
    {
        int n = 30;
        int SI = 0;

        for (int i = 1; i <= 2 * n; i += 2)
        {
            SI += i;
        }

        Console.WriteLine(SI);
    }
}

// NOTA I: A variável 'n' é inicializada com o valor 30. Ela define quantos números ímpares serão somados.

// NOTA II: A variável 'SI' é inicializada com 0. Ela será usada para armazenar a soma dos números ímpares.

// NOTA III: O loop 'for' começa com 'i' igual a 1 e incrementa 'i' em 2 a cada iteração (i += 2).
// Isso garante que 'i' sempre será um número ímpar.

// NOTA IV: O loop continua enquanto 'i' for menor ou igual a 2 * n. 
// Como 'n' é 30, o loop irá até 'i' ser 60, garantindo que somamos os primeiros 30 números ímpares.

// NOTA V: Em cada iteração, o valor de 'i' é adicionado ao valor atual de 'SI'.
// Ou seja, escrever SI += i é o mesmo que escrever SI = SI + i.