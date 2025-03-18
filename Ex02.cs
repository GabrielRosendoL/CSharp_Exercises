// Ex02: Calculando a soma de dois números.

// Definição de uma classe chamada 'Ex02'.
// Uma classe é um contêiner que pode conter métodos, propriedades e outros membros.
// Classes são fundamentais na programação orientada a objetos.
class Ex02
{
    // Definição de um método estático chamado 'Run'.
    // 'public' significa que o método pode ser acessado de fora da classe.
    // 'static' significa que o método pertence à classe e não a uma instância específica da classe.
    // Isso significa que você pode chamar o método 'Run' diretamente usando o nome da classe 'Ex02',
    // sem precisar criar um objeto dessa classe. Métodos estáticos são úteis para funcionalidades
    // que não dependem de dados específicos de uma instância da classe.
    // 'void' significa que o método não retorna nenhum valor.
    public static void Run()
    {
        // Declaração de duas variáveis inteiras, 'num1' e 'num2', e inicialização com os valores 30 e 15, respectivamente.
        int num1 = 30;
        int num2 = 15;

        // Declaração de uma variável inteira 'sum' e inicialização com a soma de 'num1' e 'num2'.
        int sum = num1 + num2;

        // O método 'Console.WriteLine' é usado para imprimir uma linha de texto no console.
        // 'Console' é uma classe fornecida pelo .NET Framework que representa a janela do console.
        // 'WriteLine' é um método dessa classe que imprime uma linha de texto no console e move o cursor 
        // para a próxima linha.
        // Neste caso, ele imprime a mensagem com a soma dos números.
        Console.WriteLine("A soma de " + num1 + " e " + num2 + " é " + sum);
    }
}

// NOTA I: A soma de dois números é calculada e armazenada na variável 'sum'.

// NOTA II: Podemos chamar as variáveis 'num1' e 'num2' de operandos e 
// a variável 'sum' de resultado dentro do Console.WriteLine.