using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i=8;
          
            bool isZero;
            if(i==0)
            { isZero = true;
                Console.WriteLine("i is zero.");
            }
            else
            {
                isZero = false;
                Console.WriteLine("i is  not zero.");
            }
        }
    }
    
}
