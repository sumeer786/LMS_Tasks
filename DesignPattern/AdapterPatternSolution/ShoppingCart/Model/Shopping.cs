using System;
using System.Collections.Generic;

namespace ShoppingCart.Model
{
    public class Shopping
    {
        private List<IItem> list = new List<IItem>();
        public Shopping()
        {

        }

        public void AddItem(IItem item)
        {
            list.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
            }
        }

        public double TotalPrice()
        {
            return 0;
        }

        public List<IItem> GetItems()
        {
            return list;
        }
    }
}
