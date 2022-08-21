using System;
namespace DecoratorHatApp.Model
{
    public class GoldenHat: IHat
    {
        private string _name;
        private double _price;
        private string _description;
        public GoldenHat()
        {
            _name = "Golden Hat";
            _price = 1000;
        }
        public string Name()
        {
            return _name;
        }

        public double Price()
        {
            return _price;
        }

        public string Description()
        {
            return "Golden Hat: " + _name + _price;
        }
    }
}
