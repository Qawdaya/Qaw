using System;

namespace Chapter_3
{
    class Program
    {
       static void SomeFunction(out int i)
        {
            i = 100;

        }
        static void Main(string[] args)
        {
            int i = 0;
          
            SomeFunction(out i);
           
            Console.WriteLine(i);
            
        }
    }
    
  }
   

    

