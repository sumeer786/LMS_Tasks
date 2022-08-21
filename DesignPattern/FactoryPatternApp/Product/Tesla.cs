using System;
namespace FactoryPatternApp.Product
{
    internal class Tesla : IAutoMobile
    {
        public Tesla()
        {

        }

        public void Start()
        {
            Console.WriteLine("Tesla Starts Moving");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla Stops Moving");
        }
    }
}
