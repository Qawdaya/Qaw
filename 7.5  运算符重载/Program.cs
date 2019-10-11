using System;
using System.Text;

namespace _7._5__运算符重载
{
    
  
    class Program
    {
        
        static void Main(string[] args)
        {
            int myInteger = 3;
            uint myUnsignedInt = 2;
            double myDouble = 4.0;
            long myLong = myInteger + myUnsignedInt;
            double myOtherDouble = myDouble + myInteger;
            Console.WriteLine(myLong);
            Console.WriteLine(myOtherDouble);

            
        }
    }
}
