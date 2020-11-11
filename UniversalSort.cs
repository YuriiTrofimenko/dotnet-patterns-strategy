using System;
using System.Collections;
namespace strategy
{
  public class UniversalSort
  {
      public delegate int Comparator(object currentItem, object nextItem);
      public static void Sort(ArrayList list, Comparator comparator) {
        bool isSorted;
        do
        {
            isSorted = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                object currentItem = list[i];
                object nextItem = list[i + 1];
                // (int)currentItem < (int)nextItem
                // 
                if (comparator(currentItem, nextItem) > 0)
                {
                    list[i] = nextItem;
                    list[i + 1] = currentItem;
                    isSorted = false;
                }
            }
        } while (!isSorted);
      }
  }
}