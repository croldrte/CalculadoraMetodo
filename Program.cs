using Calculadora;

class Program
{
    static void Main()
    {
        bool entradaValida;
        double a, b, resultado = 0;
        string operacao;

        Console.Clear();
        Console.WriteLine("::: CALCULADORA :::");

        Console.Write("Digite o primeiro número: ");
        do
        {
            entradaValida = double.TryParse(Console.ReadLine(), out a);
            if (!entradaValida)
                Console.Write("Número inválido! Tente novamente: ");
        } while (!entradaValida);

        Console.Write("Digite o segundo número: ");
        do
        {
            entradaValida = double.TryParse(Console.ReadLine(), out b);
            if (!entradaValida)
                Console.Write("Número inválido! Tente novamente: ");
        } while (!entradaValida);

        Console.Write("Escolha uma operação (+, -, *, /): ");
        do
        {
            operacao = Console.ReadLine();
            switch (operacao)
            {
                case "+":
                    entradaValida = true;
                    resultado = Operacoes.Adicionar(a, b);
                    break;
                case "-":
                    entradaValida = true;
                    resultado = Operacoes.Subtrair(a, b);
                    break;
                case "*":
                    entradaValida = true;
                    resultado = Operacoes.Multiplicar(a, b);
                    break;
                case "/":
                    if (b != 0)
                    {
                        entradaValida = true;
                        resultado = Operacoes.Dividir(a, b);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Não existe divisão por zero.");
                        return;
                    }
                default:
                    entradaValida = false;
                    Console.Write("Operação inválida! Tente novamente: ");
                    break;
            }
        } while (!entradaValida);
        Console.Clear();
        Console.WriteLine("::: CALCULADORA :::");
        Console.WriteLine($"{a} {operacao} {b} = {resultado}");
    }
}