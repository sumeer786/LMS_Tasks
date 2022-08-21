using System;
namespace ShoppingCart.Model
{
    public interface IItem
    {
        string ItemName();
        double ItemPrice();
    }
}
