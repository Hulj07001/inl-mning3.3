using System;
namespace inlämning3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Välkommen till vår bilhyrfirma.");
            Console.WriteLine("En hyrbil kostar 80kr i timmen.");
            Console.WriteLine("Hur många timmar vill du hyra en bil idag? OBS! Endast hela timmar.");
            int timmar = int.Parse(Console.ReadLine());
            int kostnad = timmar * 80;
            Console.WriteLine("För att hyra en bil i "+timmar+" timmar kommer det att kosta: "+kostnad+"kr");
        }
    }
}