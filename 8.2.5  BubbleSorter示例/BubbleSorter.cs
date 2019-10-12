using System;
using System.Collections.Generic;
using System.Text;

namespace _8._2._5__BubbleSorter示例
{
    class BubbleSorter
    {
        static public void Sort<T>(IList<T> sortArray1, Func<T, T, bool> comparison)
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray1.Count - 1; i++)
                {
                    if (comparison(sortArray1[i + 1], sortArray1[i]))
                    {
                        T temp = sortArray1[i];
                        sortArray1[i] = sortArray1[i + 1];
                        sortArray1[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);

        }
    }
}
