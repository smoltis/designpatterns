using System;
using System.Collections.Generic;

namespace Iterator
{
    public class PancakeHouseMenuIterator : IIterator
    {
        private List<string> menuItems;
        private int position = 0;

        public PancakeHouseMenuIterator(List<string> menuItems)
        {
            this.menuItems = menuItems;
        }

        public bool HasNext()
        {
            return position < menuItems.Count;
        }

        public object Next()
        {
            string menuItem = menuItems[position];
            position++;
            return menuItem;
        }

    }
}
