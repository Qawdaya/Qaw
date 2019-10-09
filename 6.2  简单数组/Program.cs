using System;

namespace _6._2__简单数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[] { 1, 2, 3, 4 };
            int v1 = myarray[0];
            int v2 = myarray[1];
            int v3 = myarray[2];
            Console.WriteLine("{0} {1} {2}", v1, v2, v3);
            for(int i=0;i<myarray.Length;i++)
            {
                Console.WriteLine(myarray[i]);
            }
            foreach(int i in myarray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
