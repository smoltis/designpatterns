using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class VegeterianMenu : IEnumerable
    {
        List<string> menuItems;

        public VegeterianMenu()
        {
            menuItems = new List<string>
            {
                "Smashed Avocado on Wholegrain Toast",
                "Rice Bowl With Beans",
                "Veggie Burger",
                "Quinoa Salad"
            };
        }

        public string this[int index]
        {
            get { return menuItems[index]; }
            set { menuItems.Insert(index, value); }
        }

        public int Count 
        {
            get { return menuItems.Count; }   
        }

        public IEnumerator GetEnumerator()
        {
            return new VegeterianMenuEnumerator(this);
        }
    }
}
