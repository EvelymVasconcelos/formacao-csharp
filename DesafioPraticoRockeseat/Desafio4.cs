namespace DesafioPraticoCSharp;
public class Desafio4
{
    public static void ContarCaracteres() {
        Console.WriteLine("Digite o que deseja:");
        string? nome = Console.ReadLine();
        if (nome is not null) {
            string[] resultado = nome.Trim().Split(" ");
            foreach (var item in resultado)
            {
                int quantidadeCaracter = item.Length;
                Console.WriteLine($"{item}: {quantidadeCaracter} caracteres");
            }
        }
    }   
}
