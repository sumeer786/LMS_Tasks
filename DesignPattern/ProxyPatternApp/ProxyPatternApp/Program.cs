using System;
using ProxyPatternApp.Model;

namespace ProxyPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RealImage image1 = new RealImage("one.jpg");
            RealImage image2 = new RealImage("two.jpg");
            RealImage image3 = new RealImage("three.jpg");
            image3.Display();


            ProxyImage image4 = new ProxyImage("four.jpg");
            ProxyImage image5 = new ProxyImage("five.jpg");
            ProxyImage image6 = new ProxyImage("six.jpg");
            image6.Display();

        }
    }
}
