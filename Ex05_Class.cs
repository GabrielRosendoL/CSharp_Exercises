// Exercício 5: Calculando o fatorial de um número

// Definição de uma classe chamada 'Ex05'.
// Uma classe é um contêiner que pode conter métodos, propriedades e outros membros.
// Classes são fundamentais na programação orientada a objetos.
class Ex05_Class
{
    // Definição de um método estático chamado 'Run'.
    // 'public' significa que o método pode ser acessado de fora da classe.
    // 'static' significa que o método pertence à classe e não a uma instância específica da classe.
    // Isso significa que você pode chamar o método 'Run' diretamente usando o nome da classe 'Ex05',
    // sem precisar criar um objeto dessa classe. Métodos estáticos são úteis para funcionalidades
    // que não dependem de dados específicos de uma instância da classe.
    // 'void' significa que o método não retorna nenhum valor.
    public static void Run()
    {
        // Declaração de uma variável inteira 'num' que armazena o número para o qual queremos calcular o fatorial.
        // Neste exemplo, estamos calculando o fatorial de 5.
        int num = 5;

        // Declaração de uma variável inteira 'factorial' inicializada com 1.
        // Essa variável será usada para armazenar o resultado do cálculo do fatorial.
        // Ela começa com 1 porque a multiplicação por 1 não altera o resultado.
        int factorial = 1;

        // Um loop 'for' que itera de 1 até o valor de 'num' (inclusive).
        // O loop é usado para calcular o fatorial multiplicando os números de 1 até 'num'.
        for (int i = 1; i <= num; i++)
        {
            // Multiplica o valor atual de 'factorial' pelo valor de 'i'.
            // O resultado é armazenado novamente na variável 'factorial'.
            // Isso significa que 'factorial *= i' é o mesmo que 'factorial = factorial * i'.
            factorial *= i;
        }

        // O método 'Console.WriteLine' é usado para imprimir uma mensagem no console.
        // Aqui, ele imprime o resultado do cálculo do fatorial.
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

// NOTA VI: O método 'Console.WriteLine' imprime o resultado do cálculo no console.
// Neste caso, ele exibe a mensagem "O fatorial de 5 é 120".