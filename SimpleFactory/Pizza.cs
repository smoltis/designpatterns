using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class Pizza
    {
        public string name;
        public string dough;
        public string sauce;

        public List<string> toppings = new List<string>();

        public Pizza()
        {
        }

        public string GetName()
        {
            return name;
        }

        public void prepare()
        {
            Console.WriteLine($"Preparing {name}");
        }

        public void bake()
        {
            Console.WriteLine($"Baking {name}");
        }

        public void cut()
        {
            Console.WriteLine($"Cutting {name}");
        }

        public void box()
        {
            Console.WriteLine($"Boxing {name}");
        }

		public override string ToString()
		{
            StringBuilder descr = new StringBuilder();
            descr.AppendLine($"---- {name} ----");
            descr.AppendLine(dough);
            descr.AppendLine(sauce);
            foreach (var it in toppings)
                descr.AppendLine(it);
            return descr.ToString();
		}
	}
}
