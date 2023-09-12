Console.WriteLine("Teste 2, testanto validação dos 4 acordes\n\n");

var escalas = new Dictionary<string, List<string>>()
{
    ["C"] = new List<string> { "C", "Dm", "Em", "F", "G", "Am", "Bº" },
    ["G"] = new List<string> { "G", "Am", "Bm", "C", "D", "Em", "F#º" },
};

Console.WriteLine("Entre com 4 acordes:");
string entradaUsuario = Console.ReadLine();

string[] entradaDividida = entradaUsuario.Split(' ');
List<string> listaDeEntrada = entradaDividida.ToList();

var escalaDosAcordesDoUsuario = escalas.FirstOrDefault(escala => entradaUsuario.All(acordeUsuario => escala.Value.Contains(entradaUsuario)));

if (string.IsNullOrEmpty(escalaDosAcordesDoUsuario.Key))
{
    Console.WriteLine("OS ACORDES INFORMADOS NÃO PERTENCEM A UMA MESMA ESCALA.");
    return;
}

Console.WriteLine($"OS ACORDES INFORMADOS ESTÃO NO TOM: {escalaDosAcordesDoUsuario.Key}");