using System.Collections.Generic;

namespace Iterator
{
    public class PancakeHouseMenu : Menu
    {
        List<string> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<string>()
            {
                "K&B's Pancake Breakfast",
                "Regular Pancake Breakfast",
                "Blueberry Pancakes",
                "Waffles"
            };
        }

        public void AddItem(string name)
        {
            menuItems.Add(name);
        }

        public List<string> GetMenuItems()
        {
            return menuItems;
        }

		public override string ToString()
		{
            return "Pancake House Menu"; 
		}

		public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }
    }
}
