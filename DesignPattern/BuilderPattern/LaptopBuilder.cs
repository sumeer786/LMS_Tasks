using System;
namespace BuilderPattern
{
    public class LaptopBuilder
    {
        private ComputerSystem computer;

        public LaptopBuilder()
        {
             computer = new ComputerSystem();
        }

        public LaptopBuilder AddRAM(string ram)
        {
            computer.RAM = ram;
            return this;
        }

        public LaptopBuilder AddHDD(string hdd)
        {
            computer.HDD = hdd;
            return this;
        }

        public LaptopBuilder AddKeyBoard(string keyboard)
        {
            computer.KeyBoard = keyboard;
            return this;
        }

        public LaptopBuilder AddMouse(string mouse)
        {
            computer.Mouse = mouse;
            return this;
        }

        public ComputerSystem GetSystem()
        {
            return computer;
        }

        public LaptopBuilder AddTouchScreen(string touchscreen)
        {
            computer.TouchScreen = touchscreen;
            return this;
        }
    }
}
 