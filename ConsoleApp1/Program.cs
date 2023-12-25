using ConsoleApp1.BLC;
using ConsoleApp1.Interfaces;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            string liblaryName = System.Configuration.ConfigurationManager.AppSettings["DBLiblaryName"];
            BLC blc = new BLC(liblaryName);

            foreach (IProducer p in blc.GetProducers())
            {
                Console.WriteLine($"{p.ID}: {p.Name}");
            }
            
            Console.WriteLine("--------------------");
            
            foreach (ICar c in blc.GetCars())
            {
                Console.WriteLine($"{c.ID}: {c.Producer.Name} {c.Name} {c.ProductionYear} {c.Transmission}");
            }
        }
    }
}
