using System;

namespace ConsoleApp2
{
    delegate double DoubleOp(double x);
    class Program
    {
        static void Main(string[] args)
        {
            DoubleOp[] operations =
            {
                MathOperations.MultiplyByTwo,
                MathOperations.Square
        };
            for(int i=0;i<operations.Length;i++)
            {
                Console.WriteLine("Using operations[{0}]:", i);
                ProcessAndDisplyNumber(operations[i], 2.0);
                ProcessAndDisplyNumber(operations[i], 7.94);
                ProcessAndDisplyNumber(operations[i], 1.414);

            }

        }
         static void ProcessAndDisplyNumber(DoubleOp action,double value)
        {
            double result = action(value);
            Console.WriteLine("Value is {0},result of operation is {1}", value, result);
        }
    }
}
