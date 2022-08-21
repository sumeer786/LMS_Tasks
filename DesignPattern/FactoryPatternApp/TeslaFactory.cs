using System;
using FactoryPatternApp.Product;

namespace FactoryPatternApp
{
    public class TeslaFactory: IAutoMobileFactory
    {
        public TeslaFactory()
        {

        }

        public IAutoMobile Make()
        {
            return new Tesla();
        }
    }
}
