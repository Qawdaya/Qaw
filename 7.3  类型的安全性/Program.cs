using System;

namespace _7._3__类型的安全性
{
    class Program
    {
        struct ItemDetails
        {
            public string Description;
            public int ApproxPrice;
        }
        
       
        static void Main(string[] args)
        {
            byte value1 = 10;
            byte value2 = 23;
            /* byte total;
             total = value1 + value2;*/
            long total;//隐式转换
            total = value1 + value2;
            Console.WriteLine(total);

            long val = 30000;
            int i = (int)val;
            Console.WriteLine(i);
            /* long val1 = 3000000000;
            int i1 = checked((int)val1);
             Console.WriteLine(i1); */
            double price = 25.30;
            int approximatePrice = (int)(price + 0.5);
            Console.WriteLine(approximatePrice);
            ushort c = 43;
            char symbol = (char)c;
            Console.WriteLine(symbol);

            double[] Prices = { 25.30, 26.20, 27.90, 30.00 };
            ItemDetails id;
            id.Description = "Hello there.";
            id.ApproxPrice = (int)(Prices[0] + 0.5);
            Console.WriteLine(id.Description);
            Console.WriteLine(id.ApproxPrice);

          /*  int? a = null;
            int b = (int)a;
            Console.WriteLine(b);*/

            int i2= 10;
            string s = i2.ToString();
            Console.WriteLine(s);

            string s3 = "100";
            int i3 = int.Parse(s3);
            Console.WriteLine(i3 + 50);

            int myIntNumber = 20;
            object myobject = myIntNumber;
            int mySecondNumber = (int)myobject;
            Console.WriteLine(mySecondNumber);

            /* long mylongNumber = 333333423;
             object myObject = (object)mylongNumber;
             int myIntNumber = (int)myObject;*/     //拆箱时要非常小心，确保得到的值变量有足够的
                                                    //空间储存拆箱中的值中的所有字节

        }
    }
}
