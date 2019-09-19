using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string s1 = "a string";
            string s2 = s1;
            Console.WriteLine("s1 is" + s1);
            Console.WriteLine("s2 is" + s2);
            s1 = "another string";
            Console.WriteLine("s1 now is" + s1);
            Console.WriteLine("s2 now is" + s2);
            Console.ReadLine();
            
        }
    }
    
}
