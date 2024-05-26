namespace DesafioPraticoCSharp;
class Desafio3
{

    public static void RealizarOperacoesMatematicas() {
        (double valor1, double valor2) = InserirValores();
        Console.WriteLine("Soma: " + Adicionar(valor1: valor1, valor2: valor2));
        Console.WriteLine("Subtração: " + Subtrair(valor1: valor1, valor2: valor2));
        Console.WriteLine("Multiplicação: " + Multiplicar(valor1: valor1, valor2: valor2));
        double? resultadoDivisao = Dividir(valor1: valor1, valor2: valor2);
        if (resultadoDivisao is null)
        {
            Console.WriteLine("Divisão por zero não é possível");
        }
        else
        {
            Console.WriteLine("Divisão: " + resultadoDivisao);
        }
        Console.WriteLine("Média: " + RealizarMedia(valor1: valor1, valor2: valor2));
    }

    public static double Adicionar(double valor1, double valor2) {
        return valor1 + valor2;
    }

    public static double Subtrair(double valor1, double valor2)
    {
        return valor1 - valor2;
    }

    public static double Multiplicar(double valor1, double valor2)
    {
        return valor1 * valor2;
    }

    public static double? Dividir(double valor1, double valor2)
    {
        double? resultado = valor2 != 0 ? valor1 / valor2 : null;
        return resultado;
    }

    public static double RealizarMedia(double valor1, double valor2)
    {
        return (valor1 + valor2) / 2;
    }

    public static (double valor1, double valor2) InserirValores()
    {
        Console.WriteLine("Informe o primeiro valor:");
        double valor1 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe o segundo valor:");
        double valor2 = double.Parse(Console.ReadLine()!);
        return (valor1, valor2);
    }
}
