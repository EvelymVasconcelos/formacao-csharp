namespace DesafioPraticoCSharp;
public class Desafio1
{
    public static void ImprimirNomeUsuario() {
        Console.WriteLine("Digite o seu nome:");
        string nome = Console.ReadLine()!;
        string resultado = nome != "" ? $"Olá, {nome.ToUpper()}! Seja muito bem-vindo!" : "Nome nao informado";
        Console.WriteLine(resultado);
    }   
}
