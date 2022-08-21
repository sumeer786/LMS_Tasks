using System;
namespace DecoratorHatApp.Model
{
    public class RibbonHat:IHat
    {
        private IHat _hat;
        private string _name;
        private double _price;
        private string description;
        public RibbonHat(IHat hat)
        {
            _hat = hat;
            _name = "Ribbion Hat";
            _price = 100;
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
            return _hat.Description() +"Ribbion Hat: " + _name + _price;
        }
    }
}
