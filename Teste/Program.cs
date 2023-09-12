using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*** Testando verificação dos 4 acordes. ***\n\n" );

        var escalas = new Dictionary<string, List<string>>
        {
            ["C"] = new List<string> { "C", "Dm", "Em", "F", "G", "Am", "Bº" },
            ["G"] = new List<string> { "G", "Am", "Bm", "C", "D", "Em", "F#º" },
            //..............
        };

        var acordesDigitadosPeloUsuario = new List<string> { "C", "D", "Em", "Bm" };

        //COMO SABER EM QUAL TOM ESTÃO ESSES ACORDES QUE O USUÁRIO DIGITOU?
        var escalaDosAcordesDoUsuario = escalas.FirstOrDefault(escala => acordesDigitadosPeloUsuario.All(acordeUsuario => escala.Value.Contains(acordeUsuario)));

        if (string.IsNullOrEmpty(escalaDosAcordesDoUsuario.Key))
        {
            Console.WriteLine("OS ACORDES INFORMADOS NÃO PERTENCEM A UMA MESMA ESCALA.");
            return;
        }

        Console.WriteLine($"OS ACORDES INFORMADOS ESTÃO NO TOM: {escalaDosAcordesDoUsuario.Key}");


    }
}