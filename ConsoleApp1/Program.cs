using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
           // Random rd = new Random();
            int i;
            // i = rd.Next();
            i = 2;
            switch (i)
            {
                case 1:
                    Console.WriteLine("i=1");
                    break;
                case 2:
                    Console.WriteLine("i=2");
                    break;
                case 3:
                    Console.WriteLine("i=3");
                    break;
                case 4:
                    Console.WriteLine("i=4");
                    break;
                default:
                    Console.WriteLine("i is not 1,2,3 or 4");
                    break;
            }
            string country = "us";
            switch (country)
            {
                case "America":
                    goto case "Britain";
                   
                case "Britain":
                   Console.WriteLine(" language = English");
                    break;


            }
            switch (country)
            {
                case "au":
                case "uk":
                case "us":
                    Console.WriteLine("language=English");
                    break;
                case "at":
                case "de":
                    Console.WriteLine("language=Geman");
                    break;
            }
        }
    }
    
}
