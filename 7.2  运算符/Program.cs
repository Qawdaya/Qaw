using System;

namespace _7._2__运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            if(++x==6)
            {
                Console.WriteLine("This will execute"); 
            }
            if(x++==7)
            {
                Console.WriteLine("This won't");
            }
            int y = 1;
            string s = y+ " ";
            s += (y == 1 ? "man" : "men");
            Console.WriteLine(s);

            byte b = 255;
            unchecked
            {
            b++;
            }
            
            Console.WriteLine(b.ToString());

            int i = 10;
            if(i is object)
            {
                Console.WriteLine("i is an object");
            }

            object o1 = "Some String";
            object o2 = 5;
            string s1 = o1 as string;
            string s2 = o2 as string;
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(sizeof(int));
            int? a = null;
            int? v = a + 4;
            int? c = a * 5;
            Console.WriteLine(v);
            Console.WriteLine(c);
            Console.WriteLine(a);
            int ? m = null;
            int? n = -5;
            if (m >= n)
                Console.WriteLine("m>=n");
            else
                Console.WriteLine("m<n");

            int? u = null;
            int d;
            d = u?? 10;
            Console.WriteLine(d);
            u = 3;
            d = u ?? 10;
            Console.WriteLine(d);

        }
    }
}
