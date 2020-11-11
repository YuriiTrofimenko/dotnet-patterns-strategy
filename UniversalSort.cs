using System;
using System.Collections;
public class UniversalSort
{
    public static void Sort(ArrayList list) {
      bool isSorted;
      do
      {
          isSorted = true;
          for (int i = 0; i < list.Count - 1; i++)
          {
              Object currentItem = list[i];
              Object nextItem = list[i + 1];
              if ((int)currentItem < (int)nextItem)
              {
                  list[i] = nextItem;
                  list[i + 1] = currentItem;
                  isSorted = false;
              }
          }
      } while (!isSorted);
    }
}