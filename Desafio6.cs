using System.Globalization;

namespace DesafioPraticoCSharp;
public class Desafio6
{
    public static void ExibirDataAtual() {
        DateTime dataAtual = DateTime.UtcNow;
        Console.WriteLine($"Data Atual Completa: {dataAtual}");
        Console.WriteLine("Data: " + dataAtual.ToString("dd/MM/yyyy"));
        Console.WriteLine("Hora: " + dataAtual.ToString("HH:mm:ss"));
        Console.WriteLine("Mês  por extenso: " + dataAtual.ToString("dd MMMM yyyy", new CultureInfo("pt-BR")));
    }
}
