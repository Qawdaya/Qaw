using System;
using System.Collections.Generic;
using System.Text;

namespace _8._2._6__多播委托
{
    class MathOperations
    {
        public static void MutiplyByTwo(double value)
        {
            double result = value * 2;
            Console.WriteLine("Mutiplying by 2:{0} give {1}", value, result);

        }
        public static void Square(double value)
        {
            double result = value * value;
            Console.WriteLine("Squaring:{0} give {1}", value, result);
        }
    }
}
