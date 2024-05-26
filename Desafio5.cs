namespace DesafioPraticoCSharp;
internal class Desafio5
{
    public static void InserirPlaca() {
        Console.WriteLine("Digite a placa do veículo:");
        string? placa = Console.ReadLine();
        string resultado = VerificarPlaca(placa) ? "Verdadeiro" : "False";
        Console.WriteLine(resultado); 
    }

    internal static bool VerificarPlaca(string? placa) {
        bool placaValida = true;
        if (placa is not null && placa.Length == 7) {
            for (int i = 0; i < 7; i++) {
                if (i < 3) {
                    bool resultado = Char.IsLetter(placa[i]);
                    if (!resultado) {
                        placaValida = false;
                    }
                } else {
                    bool resultado = Char.IsDigit(placa[i]);
                    if (!resultado) {
                        placaValida = false;
                    }
                }
            }
            
        } else {
            placaValida = false;
        }
        return placaValida;
    }
}
