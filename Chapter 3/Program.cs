using System;

namespace Chapter_3
{
    class Program
    {
       static void Demo (string result)
        {
            Demo(4);
            Console.WriteLine("test");
        }
        static void Demo(int result)
        {
            int a;
            a = result + 10;
            Console.WriteLine(a) ;
        }
        static void Main(string[] args)
        {

            Demo("r");
         

           
        }
        
    }
    
  }
   

    

