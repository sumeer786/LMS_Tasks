using System;
using FancyItemLibrary;
using ShoppingCart.Model;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Shopping cart = new Shopping();
            cart.AddItem(new HatAdapter(new Hat("sumeer", "sumeeranand", 1000)));

            foreach (var item in cart.GetItems())
            {
                Console.WriteLine("Name: " + item.ItemName());
                Console.WriteLine("Price: " + item.ItemPrice());
            }
        }
    }
}
