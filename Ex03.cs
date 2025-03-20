// Exercício 3: Requere um texto ao usuário, converte para número e verifica se é par ou ímpar.

// Definição de uma classe chamada 'Ex03'.
// Uma classe é um contêiner que pode conter métodos, propriedades e outros membros.
// Classes são fundamentais na programação orientada a objetos.
class Ex03 
{
    // Definição de um método estático chamado 'Run'.
    // 'public' significa que o método pode ser acessado de fora da classe.
    // 'static' significa que o método pertence à classe e não a uma instância específica da classe.
    // Isso significa que você pode chamar o método 'Run' diretamente usando o nome da classe 'Ex03',
    // sem precisar criar um objeto dessa classe. Métodos estáticos são úteis para funcionalidades
    // que não dependem de dados específicos de uma instância da classe.
    // 'void' significa que o método não retorna nenhum valor.
    public static void Run()
    {
        // O método 'Console.WriteLine' imprime uma mensagem no console.
        // Aqui, ele solicita ao usuário que digite um número.
        Console.WriteLine("Digite um número:");

        // O método 'Console.ReadLine' lê a entrada do usuário como texto (string).
        // A variável 'input' armazena o valor digitado pelo usuário.
        // O '?' após 'string' indica que a variável 'input' pode ser nula (nullable).
        string? input = Console.ReadLine();

        // Verifica se a entrada do usuário não é nula.
        // Isso é importante porque, se o usuário não digitar nada, 'input' será nulo.
        if (input != null) 
        {
            // Converte a entrada do usuário (que é uma string) para um número inteiro.
            // O método 'int.Parse' faz essa conversão. Se a entrada não for um número válido,
            // o programa lançará um erro.
            int num = int.Parse(input);

            // Verifica se o número é par ou ímpar.
            // O operador '%' calcula o resto da divisão de 'num' por 2.
            // Se o resto for 0, o número é par; caso contrário, é ímpar.
            if (num % 2 == 0) 
            {
                // Imprime no console que o número é par.
                Console.WriteLine(num + " é par");
            } 
            else 
            {
                // Imprime no console que o número é ímpar.
                Console.WriteLine(num + " é ímpar");
            }
        } 
        else 
        {
            // Caso a entrada do usuário seja nula, imprime uma mensagem de erro no console.
            Console.WriteLine("Entrada inválida.");
        }
    }
}

// NOTA I: O "Console.ReadLine" solicita um dado ao usuário e o armazena em uma variável.
// É importante lembrar que o valor retornado é sempre uma string.

// NOTA II: O "string?" indica que a variável 'input' pode ser nula.
// Isso é útil para evitar erros caso o usuário não digite nada.

// NOTA III: O "input != null" verifica se a entrada do usuário não é nula.
// O operador "!=" significa "diferente de".

// NOTA IV: O "int.Parse(input)" converte a string digitada pelo usuário em um número inteiro.
// Se o usuário digitar algo que não seja um número válido, o programa lançará um erro.

// NOTA V: O "if (num % 2 == 0)" verifica se o número é par ou ímpar.
// O operador '%' calcula o resto da divisão de 'num' por 2.
// Se o resto for 0, o número é par; caso contrário, é ímpar.

// NOTA VI: Caso a entrada seja nula, o programa informa ao usuário que a entrada foi inválida.
// Isso é uma forma de tratamento de erro simples para evitar que o programa quebre.