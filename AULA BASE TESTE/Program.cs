namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            c1.Modelo = "Fusca";
            c1.Ano = 1990;
            c1.Velocidade = 1;


            Console.WriteLine($"modelo é {c1.Modelo}");
        }

        
    }
}
