// Exercício 6: Calculando a soma acumulada de números até um limite

// Definição de uma classe chamada 'Ex06'.
// Uma classe é um contêiner que pode conter métodos, propriedades e outros membros.
// Classes são fundamentais na programação orientada a objetos.
class Ex06_Class
{
    // Definição de um método estático chamado 'Run'.
    // 'public' significa que o método pode ser acessado de fora da classe.
    // 'static' significa que o método pertence à classe e não a uma instância específica da classe.
    // Isso significa que você pode chamar o método 'Run' diretamente usando o nome da classe 'Ex06',
    // sem precisar criar um objeto dessa classe. Métodos estáticos são úteis para funcionalidades
    // que não dependem de dados específicos de uma instância da classe.
    // 'void' significa que o método não retorna nenhum valor.
    public static void Run()
    {
        // Declaração de uma variável inteira 'limit' que define o limite até onde queremos somar.
        // Neste exemplo, estamos somando os números de 1 até 10.
        int limit = 10;

        // Declaração de uma variável inteira 'sum' inicializada com 0.
        // Essa variável será usada para armazenar o resultado da soma acumulada.
        int sum = 0;

        // Um loop 'for' que itera de 1 até o valor de 'limit' (inclusive).
        // O loop é usado para somar os números de 1 até 'limit'.
        for (int i = 1; i <= limit; i++)
        {
            // Adiciona o valor atual de 'i' à variável 'sum'.
            // Isso significa que 'sum += i' é o mesmo que 'sum = sum + i'.
            sum += i;
        }

        // O método 'Console.WriteLine' é usado para imprimir uma mensagem no console.
        // Aqui, ele imprime o resultado da soma acumulada.
        Console.WriteLine("A soma acumulada de 1 até " + limit + " é " + sum);
    }
}

// NOTA I: A variável 'limit' define até onde queremos somar os números.
// Neste exemplo, estamos somando os números de 1 até 10.

// NOTA II: A variável 'sum' é inicializada com 0 porque a soma inicial é zero.
// Ela será usada para armazenar o resultado da soma acumulada.

// NOTA III: O loop 'for' começa com 'i' igual a 1 [int i = 1]
// e continua [i++] até 'i' ser igual a 'limit' [i <= limit].

// NOTA IV: Em cada iteração, o valor de 'i' é adicionado ao valor atual de 'sum'.
// Ou seja, escrever [sum += i] é o mesmo que escrever [sum = sum + i].

// NOTA V: O método 'Console.WriteLine' imprime o resultado da soma acumulada no console.
// Neste caso, ele exibe a mensagem "A soma acumulada de 1 até 10 é 55".