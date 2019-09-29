using System;

namespace Chapter_3
{
    class dimensions1    //类类型
    {
        public double length1=9;
        public double width1=8;
        public double diagona1
        {
            get { return length1 * length1 + width1 * width1; }

        }
    }
  
    class Program
    {
   
        static void Main(string[] args)
        {
            dimensions1 d = new dimensions1();
            WeakReference m = new WeakReference(new dimensions1());
            dimensions1 length;
            if(m.IsAlive)
            {
                length = m.Target as dimensions1;
                Console.WriteLine("没被回收，直接引用原对象");
            }
            else
            {
                length = new dimensions1();
            }

        }
    }

}




