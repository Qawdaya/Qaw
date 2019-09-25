using System;

namespace Chapter_3
{
    class Program
    {
       static void SomeFunction(int[]ints,int i)
        {
            ints[0] = 100;
            i = 100;
        }
        static void Main(string[] args)
        {
            int i = 0;
            int[] ints = { 0, 1, 2, 4, 8 };
            Console.WriteLine("i=" + i);
            Console.WriteLine("ints[0]="+ints[0]);
            Console.WriteLine("Calling SomeFuction.");
            SomeFunction(ints, i);
            Console.WriteLine("i=" + i);
            Console.WriteLine("ints[0]=" + ints[0]);
            
        }
    }
    
  }
   

    

