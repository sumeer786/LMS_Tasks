using System;
namespace FactoryPatternApp
{
    public interface IAutoMobileFactory
    {
        IAutoMobile Make();
    }
}
