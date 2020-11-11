using System;
using System.Collections;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ArrayList numbers =
              new ArrayList() {2, 4, 8, 0, -5, 12, 0, 2, 100, -6};
            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }
            System.Console.WriteLine();
            // UniversalSort.Sort(numbers, (currentItem, nextItem) => (int)currentItem - (int)nextItem);
            UniversalSort.Sort(numbers, (currentItem, nextItem) => (int)nextItem - (int)currentItem);
            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            } */

            ArrayList names =
              new ArrayList() {"John", "Bill", "Noname"};
            foreach (var name in names)
            {
                System.Console.WriteLine(name);
            }
            System.Console.WriteLine();
            UniversalSort.Sort(names, (currentItem, nextItem) => String.Compare(((string)currentItem), (string)nextItem));
            foreach (var name in names)
            {
                System.Console.WriteLine(name);
            }
        }
    }
}
