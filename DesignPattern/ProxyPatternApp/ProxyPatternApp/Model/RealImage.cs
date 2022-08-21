using System;
namespace ProxyPatternApp.Model
{
    public class RealImage:IImage
    {
        private string _fileName;
        public RealImage(string filename)
        {
            _fileName = filename;
            Console.WriteLine("Loading... " + _fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying... " + _fileName);
        }
    }
}
