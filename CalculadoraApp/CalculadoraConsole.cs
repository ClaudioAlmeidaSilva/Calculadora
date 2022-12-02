/* Projeto....: Calculadora
   Autor......: Cláudio de Almeida Silva
   Em.........: 02/12/2022 - 16:15 
   Descrição..: Realizar o calculo de Soma | Subtração | Mutiplicação | Divisão
*/

using CalculadoraApp;

int num1 = 0; int num2 = 0; string? tipoDeOperacao;

Console.WriteLine("Console pra criação de um Calculadora Simples\r");
Console.WriteLine("------------------------\n");

Console.WriteLine("Escolha a operação desejada:");
Console.WriteLine("------------------------\n");
Console.WriteLine("\ta - Adição");
Console.WriteLine("\ts - Subtração");
Console.WriteLine("\tm - Multiplicação");
Console.WriteLine("\td - Divisão");
Console.Write("Qual sua opção.....:");

tipoDeOperacao = Console.ReadLine();

Console.WriteLine("\n");
Console.Write("Entre com o primeiro valor : ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Entre com o segundo valor :");
num2 = Convert.ToInt32(Console.ReadLine());

int resultado = 0;
Operacoes operacoes = new Operacoes();

// Use a switch statement to do the math.
switch (tipoDeOperacao.ToLower())
{
    case "a":
        resultado = operacoes.Adicao(num1, num2);
        Console.WriteLine($"Resultado da sua operação....: {num1} + {num2} = " + resultado);
        Console.WriteLine("\nPressione entre para concluir...");
        break;
    case "s":
        resultado = operacoes.Subtracao(num1, num2);
        Console.WriteLine($"Resultado da sua operação....: {num1} - {num2} = " + resultado);
        Console.WriteLine("\nPressione entre para concluir...");
        break;
    case "m":
        resultado = operacoes.Mutiplicacao(num1, num2);
        Console.WriteLine($"Resultado da sua operação....: {num1} * {num2} = " + resultado);
        Console.WriteLine("\nPressione entre para concluir...");
        break;
    case "d":
        resultado = operacoes.Divisao(num1, num2);
        Console.WriteLine($"Resultado da sua operação....: {num1} / {num2} = " + resultado);
        Console.WriteLine("\nPressione entre para concluir...");
        break;
}