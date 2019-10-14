using System;

namespace _8._2._7__匿名方法
{
    class Program
    {
        static void Main(string[] args)
        {
            string mid = ",middle part";
            Func<string, string> anonDel = delegate (string param)
               {
                   param += mid;
                   param += "and this was added to the string.";
                   return param;
               };
            Console.WriteLine(anonDel("Start of string"));
        }
    }
}
