using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    public class DinerMenuIterator : IIterator
    {
        private Dictionary<int, string> menuItems;
        private int position = 1;

        public DinerMenuIterator(Dictionary<int, string> menuItems)
        {
            this.menuItems = menuItems;
        }

        public bool HasNext()
        {
            return position < menuItems.Count;
        }

        public object Next()
        {
            var menuItem = menuItems.ElementAt(position).Value;
            position++;
            return menuItem;
        }
    }
}
