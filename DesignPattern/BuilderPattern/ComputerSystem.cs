using System;
namespace BuilderPattern
{
    public class ComputerSystem
    {
        private string _RAM;
        private string _HDD;
        private string _keyBoard;
        private string _Mouse;
        private string _TouchScreen;

        public string RAM
        {
            get { return _RAM; }
            set { _RAM = value; }
        }

        public string HDD
        {
            get { return _HDD; }
            set { _HDD = value; }
        }

        public string KeyBoard
        {
            get { return _keyBoard; }
            set { _keyBoard = value; }
        }

        public string Mouse
        {
            get { return _Mouse; }
            set { _Mouse = value; }
        }

        public string TouchScreen
        {
            get { return _TouchScreen; }
            set { _TouchScreen = value; }
        }


        public override string ToString()
        {
            return "RAM: " + RAM + "\nHDD: " + HDD + "\nKeyBoard: " + KeyBoard + "\nMouse: " + "\nTouchScreen: " + TouchScreen;

        }
    }
}
