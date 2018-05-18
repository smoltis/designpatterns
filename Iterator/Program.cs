using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        /*
         * The Iterator Pattern
         * 
         * Provides a way to access the elements of an aggregate object 
         * sequentially without exposing its underlying representation.
         * 
         * Example:
         * Print out menu of the cafe and print out the categories of the meal.
         * 
         * 1. Ask the object for its iterator.
         * 2. Use iterator to iterate through the items in the aggregate.
         * 3. Iteration code works with any kind of agregate objects.
         * 
         * A class should have only one reason to change. (Design Principle #6)
         * 
         * 
         */

        static void Main(string[] args)
        {
            var pancakeHouseMenue = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            IEnumerable vegMenu = new VegeterianMenu();

            IIterator pancakeHouseIter = pancakeHouseMenue.CreateIterator();
            IIterator dinerMenuIter = dinerMenu.CreateIterator();
            //IEnumerator vegMenuEnu = vegMenu.GetEnumerator();

            Console.WriteLine("MENU (with iterators)\n----\nBREAKFAST");
            PrintMenu(pancakeHouseIter);
            Console.WriteLine("LUNCH");
            PrintMenu(dinerMenuIter); 
            Console.WriteLine("VEGETERIAN");
            foreach(var i in vegMenu)
                Console.WriteLine(i as string); 

        }

        private static void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next() as string);
            }
        }
    }
}
