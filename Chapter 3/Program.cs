using System;

namespace Chapter_3
{
    class Program
    {
       static void SomeFunction(int[]ints,ref int i)
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
            SomeFunction(ints, ref i);
            Console.WriteLine("i=" + i);
            Console.WriteLine("ints[0]=" + ints[0]);
            
        }
    }
    
  }
   

    

