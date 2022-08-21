using System;
namespace FactoryPatternApp.Product
{
    internal class BMW : IAutoMobile
    {
        public BMW()
        {

        }

        public void Start()
        {
            Console.WriteLine("BMW Starts Moving");
        }

        public void Stop()
        {
            Console.WriteLine("BMW Stops Moving");
        }
    }
}
