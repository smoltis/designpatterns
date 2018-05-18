using System.Collections.Generic;

namespace Iterator
{
    public class DinerMenu : Menu
    {
        Dictionary<int, string> menuItems;

        public DinerMenu()
        {
            menuItems = new Dictionary<int, string>()
            {
                {1,"Vegetarian BLT"},
                {2,"BLT"},
                {3,"Soup of the day"},
                {4,"Hotdog"},
                {5,"Steamed Veggies and Brown Rice"},
                {6,"Pizza"},
                {7,"Pasta"}
            };
        }

        public void AddItem(string name)
        {
            var idx = menuItems.Count;
            menuItems.Add(idx++, name);
        }

        public Dictionary<int,string> GetMenuItems()
        {
            return menuItems;
        }

        public override string ToString()
        {
            return "Diner Menu";
        }


        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}
