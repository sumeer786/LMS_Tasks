using System;
namespace ProxyPatternApp.Model
{
    public class ProxyImage:IImage
    {
        private string _fileName;
        public RealImage realImage;
        public ProxyImage(string filename)
        {
            _fileName = filename;
        }

        public void Display()
        {
            if(realImage == null)
            {
                realImage = new RealImage("abc.jpg");
            }
            realImage.Display();
        }
    }
}
