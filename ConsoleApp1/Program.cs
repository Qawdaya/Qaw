using System;

namespace ConsoleApp1
{
    public enum TimeofDay
    {
        morning=0,
            afternoon=1,
            evening=2
    }
    class Program
    {
        
        static void Main(string[] args)
        {
           /*获取枚举字符串*/
            TimeofDay time = TimeofDay.morning;
            Console.WriteLine(time.ToString());
            /*枚举传递值*/
            WriteGreeting(TimeofDay.morning);
            /*字符串中获取枚举值*/
            TimeofDay time2 = (TimeofDay)Enum.Parse(typeof(TimeofDay), "morning", true);
            Console.WriteLine((int)time2);
        }
        static void WriteGreeting(TimeofDay timeofDay)
        {
            switch(timeofDay)
            {
                case TimeofDay.morning:
                    Console.WriteLine("Good morning!");
                    break;
                case TimeofDay.afternoon:
                    Console.WriteLine("Good afternoon!");
                    break;
                case TimeofDay.evening:
                    Console.WriteLine("Good evening!");
                    break;
                default:
                    Console.WriteLine("Hello!");
                    break;
            }
        }
    }
    
}
