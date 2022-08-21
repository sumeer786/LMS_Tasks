using System;
using FancyItemLibrary;

namespace ShoppingCart.Model
{
    public class HatAdapter : IItem
    {
        private Hat _hat;
        public HatAdapter(Hat hat)
        {
            _hat = hat;
        }

        public string ItemName()
        {
            return _hat.GetShortName;
        }

        public double ItemPrice()
        {
            return _hat.GetPrice;
        }
    }
}
