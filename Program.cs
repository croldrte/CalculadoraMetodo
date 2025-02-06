using Calculadora;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("::: CALCULADORA :::");
        Console.Write("Digite o primeiro número: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Escolha uma operação (+, -, *, /): ");
        string operacao = Console.ReadLine();
        double resultado = 0;
        switch (operacao)
        {
            case "+":
                resultado = Operacoes.Adicionar(a, b);
                break;
        }
        Console.WriteLine($"O resultado é: {resultado}.");
    }
}