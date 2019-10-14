using System;

namespace _8._3__lambda表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            string mid = ",middle part,";
            Func<string, string> lambda = param =>
                {
                    param += mid;
                    param += "and this was added to the string,";
                    return param;
                };
            Console.WriteLine(lambda("Start of string"));
            Func<string, string> onParam = s =>
                string.Format("change uppercase {0}", s.ToUpper());
            Console.WriteLine(onParam("test"));
            Func<double, double, double> twoParams = (x, y) => x * y;
            Console.WriteLine(twoParams(3, 2));
            Func<double, double, double> Twoparamwithtypes = (double x, double y) => x * y;
            Console.WriteLine(Twoparamwithtypes(4, 2));
            Console.ReadKey();
        }
    }
}
