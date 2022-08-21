using System;

namespace FactoryPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TeslaFactory tesla = new TeslaFactory();
            var auto = tesla.Make();
            Console.WriteLine(auto.GetType());
            auto.Start();
            auto.Stop();

            Console.WriteLine("\n");

            AudiFactory audi = new AudiFactory();
            var auto1 = audi.Make();
            Console.WriteLine(auto1.GetType());
            auto1.Start();
            auto1.Stop();
        }
    }
}
