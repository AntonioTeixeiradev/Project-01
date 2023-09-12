using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

public class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Project 01");

            List<string> listaDeAcordesValidos = new List<string>
            {
                "C",
                "C#",
                "D",
                "D#",
                "E",
                "F",
                "F#",
                "G",
                "G#",
                "A",
                "A#",
                "B",
                "Cm",
                "C#m",
                "Dm",
                "D#m",
                "Em",
                "Fm",
                "F#m",
                "Gm",
                "G#m",
                "Am",
                "A#m",
                "Bm"
            };

            Console.WriteLine("Digite o tom inicial : ");
            string inputTomInicial = Console.ReadLine();

            VerificarEntradaExisteNaLista(inputTomInicial, listaDeAcordesValidos);

            Console.WriteLine("Digite 4 acordes : ");
            string inputAcordesUser = Console.ReadLine();

            VerificarEntradaDeQuatroAcordesNaLista(inputAcordesUser, listaDeAcordesValidos);

            Console.WriteLine("Digite o tom desejado : ");
            string inputTomDesejado = Console.ReadLine();

            VerificarEntradaExisteNaLista(inputTomDesejado, listaDeAcordesValidos);
        }
        catch
        {
            return;
        }
    }
    public static void VerificarEntradaExisteNaLista(string entrada, List<string> lista)
    {
        bool entradaNulaOuVazia = string.IsNullOrEmpty(entrada);
        if (entradaNulaOuVazia)
        {
            Console.WriteLine("Ops... Não digitou nada.");
            throw new Exception();
        }
        bool entradaExisteNaLista = lista.Contains(entrada);
        if (!entradaExisteNaLista) 
        {
            Console.WriteLine($"{entrada}, não contém na lista de acordes validos");
            throw new Exception();
        }
        Console.WriteLine("Correto!");
    }

    public static void VerificarEntradaDeQuatroAcordesNaLista(string entrada, List<string> lista)
    {
        bool entradaNulaOuVazia = string.IsNullOrEmpty(entrada);
        if (entradaNulaOuVazia)
        {
            Console.WriteLine("Ops... Não digitou nada.");
            throw new Exception();
        }

        List<string> listaDeAcordes;

        string[] textoDividido = entrada.Split(' ');
        listaDeAcordes = textoDividido.ToList();

        bool entradaTemQuatroItens = listaDeAcordes.Count() == 4;
        if (!entradaTemQuatroItens)
        {
            Console.WriteLine("Numero de acordes inválido.");
            throw new Exception();
        }

        var listaDeAcordesInvalidos = listaDeAcordes.Where(acorde => !lista.Contains(acorde));
        string acordesValidosEmUmaString = string.Join(" ", listaDeAcordesInvalidos);

        bool existeAlgumAcordeInvalido = listaDeAcordesInvalidos.Any();
        if (existeAlgumAcordeInvalido)
        {
            Console.WriteLine($"Os acordes: {acordesValidosEmUmaString}, são inválidos.");
            throw new Exception();
        }
        Console.WriteLine("Proximo passo...");
    }
}