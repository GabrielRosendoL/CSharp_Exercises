// Exercício 3: Requere um texto ao usuário. Converte para número e verifica se é par ou ímpar.

class Ex03 
{
    public static void Run()
    {
        Console.WriteLine("Digite um número:");
        string? input = Console.ReadLine();

        if (input != null) 
        {
            int num = int.Parse(input);


            if (num % 2 == 0) 
            {
                Console.WriteLine(num + " é par");
            } 

            else 
            {
                Console.WriteLine(num + " é ímpar");
            }
        } 
        
        else 
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}

// NOTA I: O "Console.ReadLine" solicita um dado ao usuário e o armazena em uma variável


// NOTA II: O "string?" indica que a variável 'input' pode ser nula

// NOTA III: O "input != null" verifica se a entrada do usuário não é nula.
// O próprio "!=" é uma forma de dizer que algo tem que ser "diferente de..."

// NOTA IV: Perceba que também estamos trabalhando com conversão,
// já que pedimos ao usuário um texto (string), mas iremos trabalhar com número.
// O responsável por essa conversão é o "int.Parse(nossa_viarável_de_texto)


// NOTA V: O if (num % 2 == 0) verifica se o número é par ou ímpar 
// e imprime o resultado no console.
// O operador '%' calcula o resto da divisão de 'num' por 2.
// Se o resto for 0, o número é par; caso contrário, é ímpar.

// NOTA VI: Informa ao usuário que a entrada foi inválida
// Se 'input' for nulo, esta mensagem será exibida.
// Essa parte funciona mais como um tratamento de erro.