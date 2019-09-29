using System;

namespace Chapter_3
{
    class dimensions1    //类类型
    {
        public double length1;
        public double width1;
        public double diagona1
        {
            get { return length1 * length1 + width1 * width1; }

        }
    }
    struct dimensions2  //结构
    {
        public double length2;
        public double width2;
        public  dimensions2(double length,double width)
        {
            length2 = length;
            width2 = width;
        }
        public double diagona1
        {
            get { return length2 * length2 + width2 * width2; }

        }
    }
    class Program
    {
   
        static void Main(string[] args)
        {
            dimensions2 point;
            point.length2 = 2;
            point.width2 = 4;
            Console.WriteLine(point.diagona1.ToString()); //结构调用1
            dimensions2 d = new dimensions2();
            d.length2 = 3;
            d.width2 = 5;
            Console.WriteLine(d.diagona1.ToString());//结构调用2
            dimensions1 c = new dimensions1();
            c.length1 = 3;
            c.width1 = 5;
            Console.WriteLine(c.diagona1. ToString());//类的调用

        }
    }

}




