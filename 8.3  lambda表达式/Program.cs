using System;
using System.Collections.Generic;

namespace _8._3__lambda表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new List<int>() { 10, 20, 30 };
            var funcs = new List<Func<int>>();
            foreach(var val in values)
            {
                var v = val;
                funcs.Add(() => v);

            }
            foreach(var f in funcs)
            {
                Console.WriteLine((f()));
            }
        }
    }
}
