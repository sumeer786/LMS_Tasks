using System;
using FactoryPatternApp.Product;

namespace FactoryPatternApp
{
    public class BMWFactory: IAutoMobileFactory
    {
        public BMWFactory()
        {

        }

        public IAutoMobile Make()
        {
            return new BMW();
        }
    }
}
