using Exercicio;

internal class Program
{
    private static void Main(string[] args)
    {
        AgendaTelefonica ag = new AgendaTelefonica();
        ag.inserir("Arthur1", "1");
        ag.inserir("Arthur2", "2");
        ag.inserir("Arthur3", "3");
        ag.inserir("Arthur4", "4");

        ag.buscarNumero("Arthur1");

        Console.WriteLine($"O numero desse nome eh: {ag.buscarNumero("Arthur1")}");
    }
}