using System;

namespace _8._2._6__多播委托
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<double> operations = MathOperations.MutiplyByTwo;
            operations += MathOperations.Square;
            ProcessAndDisplayNumber(operations, 2.0);
            ProcessAndDisplayNumber(operations, 7.94);
            ProcessAndDisplayNumber(operations, 1.414);
            Console.WriteLine();
        }
        static void ProcessAndDisplayNumber(Action<double> action,double value)
        {
            Console.WriteLine();
            Console.WriteLine("ProcessAndDisplayNumber called with value = {0}", value);
            action(value);
        }
    }
}
