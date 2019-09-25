using System;

namespace Chapter_3
{
    class Program
    {
       static void Demo (int nota,int a=10)
        {
           System.Console.WriteLine(a + nota);
        }
        static void Main(string[] args)
        {

            Demo(3);
            Demo(3, 4);
         

           
        }
        
    }
    
  }
   

    

