namespace DesafioPraticoCSharp;
public class Desafio2
{
    public static void ImprimirNomeSobrenomeUsuario() {
        Console.WriteLine("Digite o seu nome:");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Digite o seu sobrenome:");
        string sobrenome = Console.ReadLine()!;
        Console.WriteLine($"{nome.ToUpper()} {sobrenome.ToUpper()}");
    }   
}
