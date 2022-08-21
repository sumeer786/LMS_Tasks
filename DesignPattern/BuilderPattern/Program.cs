using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerSystem system = new LaptopBuilder()
                .AddRAM("8GB")
                .AddHDD("1000GB")
                .AddKeyBoard("Logitech")
                .AddMouse("Lenovo")
                .AddTouchScreen("Logitech")
                .GetSystem();

            Console.WriteLine(system);

        }

       
    }
}
