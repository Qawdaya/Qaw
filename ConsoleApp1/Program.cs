using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i=0;i<=100;i++)
            {  
                Console.Write( " "+i);
                int j;
                j = i % 10;
               if(j==0)
                {
                    Console.WriteLine();
                }
            }
         /*                                  */
            for(int a=0;a<100;a+=10)
            {
                for(int b=a;b<a+10;b++)
                {
                    Console.Write(" " + b);

                }
                Console.WriteLine();
            }
         }
    }
}
