// Exercício 4: Calculando a média de três números

// Definição de uma classe chamada 'Ex04'.
// Uma classe é um contêiner que pode conter métodos, propriedades e outros membros.
// Classes são fundamentais na programação orientada a objetos.
class Ex04 
{
    // Definição de um método estático chamado 'Run'.
    // 'public' significa que o método pode ser acessado de fora da classe.
    // 'static' significa que o método pertence à classe e não a uma instância específica da classe.
    // Isso significa que você pode chamar o método 'Run' diretamente usando o nome da classe 'Ex04',
    // sem precisar criar um objeto dessa classe. Métodos estáticos são úteis para funcionalidades
    // que não dependem de dados específicos de uma instância da classe.
    // 'void' significa que o método não retorna nenhum valor.
    public static void Run()
    {
        // Solicita ao usuário que digite o primeiro número.
        Console.WriteLine("Digite o primeiro número:");
        // Lê a entrada do usuário como texto (string) e armazena na variável 'input1'.
        // O '?' após 'string' indica que a variável pode ser nula (nullable).
        string? input1 = Console.ReadLine();

        // Solicita ao usuário que digite o segundo número.
        Console.WriteLine("Digite o segundo número:");
        // Lê a entrada do usuário como texto (string) e armazena na variável 'input2'.
        string? input2 = Console.ReadLine();

        // Solicita ao usuário que digite o terceiro número.
        Console.WriteLine("Digite o terceiro número:");
        // Lê a entrada do usuário como texto (string) e armazena na variável 'input3'.
        string? input3 = Console.ReadLine();

        // Verifica se todas as entradas do usuário não são nulas.
        // Isso é importante para evitar erros caso o usuário não digite nada.
        if (input1 != null && input2 != null && input3 != null) 
        {
            // Converte as entradas do usuário (que são strings) para números inteiros.
            // O método 'int.Parse' faz essa conversão. Se a entrada não for um número válido,
            // o programa lançará um erro.
            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);
            int num3 = int.Parse(input3);
            
            // Calcula a média dos três números.
            // A soma dos três números é dividida por 3.0 (um número decimal) para garantir que o resultado
            // seja um número de ponto flutuante (double) e não um inteiro.
            double media = (num1 + num2 + num3) / 3.0;

            // Imprime no console o resultado da média.
            Console.WriteLine("A média é " + media);
        } 
        else 
        {
            // Caso uma ou mais entradas sejam nulas, imprime uma mensagem de erro no console.
            Console.WriteLine("Uma ou mais entradas foram inválidas.");
        }
    }
}

// NOTA I: O "Console.ReadLine" solicita um dado ao usuário e o armazena em uma variável.
// É importante lembrar que o valor retornado é sempre uma string.

// NOTA II: O "string?" indica que as variáveis 'input1', 'input2' e 'input3' podem ser nulas.
// Isso é útil para evitar erros caso o usuário não digite nada.

// NOTA III: O "input1 != null && input2 != null && input3 != null" verifica se todas as entradas
// do usuário não são nulas. O operador "&&" significa "e", ou seja, todas as condições devem ser verdadeiras.

// NOTA IV: O "int.Parse(input1)" converte a string digitada pelo usuário em um número inteiro.
// Se o usuário digitar algo que não seja um número válido, o programa lançará um erro.

// NOTA V: O cálculo da média usa "3.0" (um número decimal) para garantir que o resultado seja um número
// de ponto flutuante (double). Isso evita que o resultado seja truncado para um número inteiro.

// NOTA VI: Caso uma ou mais entradas sejam inválidas, o programa informa ao usuário que houve um erro.
// Isso é uma forma básica de tratamento de erros para evitar que o programa quebre.