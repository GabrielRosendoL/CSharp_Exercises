// Ex01: Imprimindo um texto no console.

// Definição de uma classe chamada 'Ex01'.
// Uma classe é um contêiner que pode conter métodos, propriedades e outros membros.
// Classes são fundamentais na programação orientada a objetos.
class Ex01_Class
{
    // Definição de um método estático chamado 'Run'.
    // 'public' significa que o método pode ser acessado de fora da classe.
    // 'static' significa que o método pertence à classe e não a uma instância específica da classe.
    // Isso significa que você pode chamar o método 'Run' diretamente usando o nome da classe 'Ex01',
    // sem precisar criar um objeto dessa classe. Métodos estáticos são úteis para funcionalidades
    // que não dependem de dados específicos de uma instância da classe.
    // 'void' significa que o método não retorna nenhum valor.
    public static void Run()
    {
        // O método 'Console.WriteLine' é usado para imprimir uma linha de texto no console.
        // 'Console' é uma classe fornecida pelo .NET Framework que representa a janela do console.
        // 'WriteLine' é um método dessa classe que imprime uma linha de texto no console e move o cursor 
        // para a próxima linha.
        // Neste caso, ele imprime a mensagem "Hello World".
        Console.WriteLine("Hello World");
    }
}

// NOTA I: O "Console.WriteLine" imprime no console.
// NOTA II: O método 'Run' pode ser chamado de qualquer lugar do código, pois é público e estático.