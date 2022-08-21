using System;
namespace DecoratorHatApp.Model
{
    public class StandardHat:IHat
    {
        private IHat _hat;
        private string _name;
        private double _price = 50;
        private string _description;
        public StandardHat(IHat hat)
        {
            _hat = hat;
            _name = "Standard Hat";
            _price = 50;
        }

        public string Name()
        {
            return _name + _hat.Name();
        }

        public double Price()
        {
            return _price + _hat.Price();
        }

        public string Description()
        {
            return _hat.Description() + "Standard Hat: " + _name + _price;
        }
    }
}
