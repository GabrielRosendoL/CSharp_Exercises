// Exercício 01: Imprimindo no Console
// 
// Objetivo: Completar o código abaixo para imprimir duas mensagens no console.
// 
// Instruções:
// 1. Complete o método Run() para imprimir as mensagens
// 2. Use o Console.WriteLine() para imprimir cada texto
// 3. A primeira mensagem deve ser "Bem-vindo ao C#!"
// 4. A segunda mensagem deve ser "Esse será meu primeiro exercício!"
// 5. As mensagens devem ser impressas uma em cada linha

using System.Text;

class Ex01
{
    public static void Run()
    {
        // Configura o console para usar UTF-8
        Console.OutputEncoding = Encoding.UTF8;
        
        // Complete o código aqui para imprimir as duas mensagens
        
    }
}

// NOTA: O 'using System.Text;' e o 'Console.OutputEncoding = Encoding.UTF8;' NÃO SÃO OBRIGATÓRIOS.
// Eles são usados para configurar o console para usar UTF-8, permitindo o uso de caracteres especiais. Vamos usá-los apenas
// para fins de estudo.

// NOTA II: O C# usa codificação UTF-16 internamente, então suporta caracteres especiais como acentos, ç, etc.
// No entanto, o comportamento pode variar dependendo do console/terminal que está sendo usado:
// No Windows, o console padrão (cmd) pode ter problemas com caracteres especiais se não estiver configurado 
// corretamente;

// O PowerShell geralmente lida melhor com caracteres especiais

// IDEs como Visual Studio e VS Code geralmente exibem corretamente os caracteres especiais

