using System;
namespace _7._4__比较对象的相等性
{
    class x
    {

    }
    class y
    {

    }
    class Program
    {
       
        static void Main(string[] args)
        {
            /*ReferenceEquals()方法*/
            x x = new x();
            y y = new y();
            bool B1 = ReferenceEquals(null, null);
            bool B2 = ReferenceEquals(x, null);
            bool B3 = ReferenceEquals(x, y);
            Console.WriteLine(B1);
            Console.WriteLine(B2);
            Console.WriteLine(B3);
            
        }
    }
}
