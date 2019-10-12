using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _8._2._5__BubbleSorter示例
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortArray = { 0, 5, 6, 2, 1 };
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (sortArray[i] > sortArray[i + 1])
                    {
                        int temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
            for(int v=0;v<sortArray.Length;v++)
            { Console.WriteLine(sortArray[v]); }
        }
    }
}
