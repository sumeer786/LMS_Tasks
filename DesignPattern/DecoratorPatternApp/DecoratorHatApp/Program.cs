using System;
using DecoratorHatApp.Model;

namespace DecoratorHatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RibbonHat hat = new RibbonHat(new GoldenHat());
            PrintDetails(hat);
            StandardHat hat1 = new StandardHat(new PermiumHat());
            PrintDetails(hat1);
        }

        public static void PrintDetails(IHat hat)
        {
            Console.WriteLine(hat.Name());
            Console.WriteLine(hat.Price());
            Console.WriteLine(hat.Description());
        }
    }
}
