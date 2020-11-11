using System;
using System.Collections;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers =
              new ArrayList() {2, 4, 8, 0, -5, 12, 0, 2, 100, -6};
            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }
            System.Console.WriteLine();
            UniversalSort.Sort(numbers);
            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }
        }
    }
}
