using System;
namespace FactoryPatternApp.Product
{
    internal class Audi : IAutoMobile
    {
        public Audi()
        {

        }

        public void Start()
        {
            Console.WriteLine("Audi Starts Moving");
        }

        public void Stop()
        {
            Console.WriteLine("Audi Stops Moving");
        }
    }
}
