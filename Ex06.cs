// Exercício 6: Realizando uma série de iterações

class Ex06
{

    public static void Run()
    {
        int n = 10;
        int maxIterations = 108;
        int iterationCount = 0;

        for (int i = 1; i <= n && iterationCount < maxIterations; i++)
        {
            n = n + i;
            iterationCount++;
        }

        Console.WriteLine("O resultado é: " + n);
    }

}

// NOTA I: A variável 'n' é inicializada com o valor 10. Ela será atualizada em cada iteração do loop.

// NOTA II: A variável 'maxIterations' define o número máximo de iterações que o loop pode executar.
// Neste exemplo, o valor é 108.

// NOTA III: A variável 'iterationCount' é usada para contar quantas iterações foram realizadas.
// Ela é inicializada com 0 e incrementada em cada iteração do loop.

// NOTA IV: O loop 'for' começa com 'i' igual a 1.
// Irá ontinuar enquanto 'i' for menor ou igual a 'n' 
// e 'iterationCount' for menor que 'maxIterations'.
// Em cada iteração, o valor de 'i' é somado ao valor atual de 'n' 
// com o resultado sendo armazenado em 'n'.
// Ou seja, escrever n = n + i é o mesmo que escrever n += i.

