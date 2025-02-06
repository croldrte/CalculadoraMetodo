using Calculadora;

class Program
{
    static void Main()
    {
        bool numeroValido;
        double a, b;

        Console.Clear();
        Console.WriteLine("::: CALCULADORA :::");
        Console.Write("Digite o primeiro número: ");
        do
        {
            numeroValido = double.TryParse(Console.ReadLine(), out a);
            if (!numeroValido)
                Console.Write("Número inválido! Tente novamente: ");
        } while (!numeroValido);

        Console.Write("Digite o segundo número: ");
        do
        {
            numeroValido = double.TryParse(Console.ReadLine(), out b);
            if (!numeroValido)
                Console.Write("Número inválido! Tente novamente: ");
        } while (!numeroValido);

        Console.Write("Escolha uma operação (+, -, *, /): ");
        string operacao = Console.ReadLine();
        double resultado = 0;
        switch (operacao)
        {
            case "+":
                resultado = Operacoes.Adicionar(a, b);
                break;
            case "-":
                resultado = Operacoes.Subtrair(a, b);
                break;
            case "*":
                resultado = Operacoes.Multiplicar(a, b);
                break;
            case "/":
                if (b != 0)
                {
                    resultado = Operacoes.Dividir(a, b);
                    break;
                }
                else
                {
                    Console.WriteLine("Não existe divisão por zero.");
                    return;
                }
        }
        Console.WriteLine($"O resultado é: {resultado}.");
    }
}