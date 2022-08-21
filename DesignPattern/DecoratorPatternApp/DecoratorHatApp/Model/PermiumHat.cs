using System;
namespace DecoratorHatApp.Model
{
    public class PermiumHat : IHat
    {
        private string _name;
        private double _price;
        private string _description;
        public PermiumHat()
        {
            _name = "Permium Hat";
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
            return "Permium Hat: " + _name + _price;
        }
    }
}
