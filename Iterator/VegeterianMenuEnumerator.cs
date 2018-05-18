using System.Collections;

namespace Iterator
{
    internal class VegeterianMenuEnumerator : IEnumerator
    {
        private VegeterianMenu vegeterianMenu;

        private int current = -1;

        public VegeterianMenuEnumerator(VegeterianMenu vegeterianMenu)
        {
            this.vegeterianMenu = vegeterianMenu;
        }

        public object Current {
            get { return vegeterianMenu[current]; } 
        }

        public bool MoveNext()
        {
            if (current < vegeterianMenu.Count - 1)
            {
                current++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            current = -1;
        }
    }
}