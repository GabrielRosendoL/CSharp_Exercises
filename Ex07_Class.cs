// Exercício 7: Calculando a soma dos primeiros 30 números ímpares

// Definição de uma classe chamada 'Ex07'.
// Uma classe é um contêiner que pode conter métodos, propriedades e outros membros.
// Classes são fundamentais na programação orientada a objetos.
class Ex07_Class
{
    // Definição de um método estático chamado 'Run'.
    // 'public' significa que o método pode ser acessado de fora da classe.
    // 'static' significa que o método pertence à classe e não a uma instância específica da classe.
    // Isso significa que você pode chamar o método 'Run' diretamente usando o nome da classe 'Ex07',
    // sem precisar criar um objeto dessa classe. Métodos estáticos são úteis para funcionalidades
    // que não dependem de dados específicos de uma instância da classe.
    // 'void' significa que o método não retorna nenhum valor.
    public static void Run()
    {
        // Declaração de uma variável inteira 'n' inicializada com o valor 30.
        // Essa variável define quantos números ímpares serão somados.
        int n = 30;

        // Declaração de uma variável inteira 'SI' inicializada com 0.
        // Essa variável será usada para armazenar a soma dos números ímpares.
        int SI = 0;

        // Um loop 'for' que começa com 'i' igual a 1 e incrementa 'i' em 2 a cada iteração.
        // Isso garante que 'i' sempre será um número ímpar.
        // O loop continua enquanto 'i' for menor ou igual a 2 * n.
        // Como 'n' é 30, o loop irá até 'i' ser 59, garantindo que somamos os primeiros 30 números ímpares.
        for (int i = 1; i <= 2 * n; i += 2)
        {
            // Adiciona o valor atual de 'i' à variável 'SI'.
            // Isso significa que 'SI += i' é o mesmo que 'SI = SI + i'.
            SI += i;
        }

        // O método 'Console.WriteLine' é usado para imprimir uma mensagem no console.
        // Aqui, ele imprime o resultado da soma dos primeiros 30 números ímpares.
        Console.WriteLine("A soma dos primeiros " + n + " números ímpares é " + SI);
    }
}

// NOTA I: A variável 'n' define quantos números ímpares serão somados.
// Neste exemplo, 'n' é 30, então somaremos os primeiros 30 números ímpares.

// NOTA II: A variável 'SI' é inicializada com 0 porque a soma inicial é zero.
// Ela será usada para armazenar o resultado da soma acumulada dos números ímpares.

// NOTA III: O loop 'for' começa com 'i' igual a 1 [int i = 1]
// e incrementa 'i' em 2 a cada iteração [i += 2], garantindo que 'i' sempre será um número ímpar.

// NOTA IV: O loop continua enquanto 'i' for menor ou igual a 2 * n [i <= 2 * n].
// Como 'n' é 30, o loop irá até 'i' ser 59, garantindo que somamos os primeiros 30 números ímpares.

// NOTA V: Em cada iteração, o valor de 'i' é adicionado ao valor atual de 'SI'.
// Ou seja, escrever [SI += i] é o mesmo que escrever [SI = SI + i].

// NOTA VI: O método 'Console.WriteLine' imprime o resultado da soma acumulada no console.
// Neste caso, ele exibe a mensagem "A soma dos primeiros 30 números ímpares é 900".