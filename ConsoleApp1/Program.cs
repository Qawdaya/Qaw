using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 20;
            Console.WriteLine("{0} plus {1} equal {2}",i,j,i+j);
            Console.WriteLine("{0,4} plus {1,4} equal {2,4}", i, j, i + j);
            Console.WriteLine("\n{0,10}\n plus {1,4}\n ------------\nequal {2,4}", i, j, i + j);

            double A = 0.234;
            Console.WriteLine("{0:#.00}",A);

        }
      
       

    }
}

