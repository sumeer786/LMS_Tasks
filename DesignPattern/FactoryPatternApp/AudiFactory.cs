using System;
using FactoryPatternApp.Product;

namespace FactoryPatternApp
{
    public class AudiFactory: IAutoMobileFactory
    {
        public AudiFactory()
        {

        }

        public IAutoMobile Make()
        {
            return new Audi();
        }
    }
}
