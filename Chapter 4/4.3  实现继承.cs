using System;

namespace Chapter_4
{
   class MyDrivedClass:MyBaseClass
    {
        public override string VirtualMethod()
        {
            return VirtualMethod();
        }
    }
    class MyBaseClass
    {
        public virtual string VirtualMethod()
        {
            return "This method is virtual and defind in MyBaseClass";
        }
        public virtual string foreName
        {
            get { return ForeName; }
            set { ForeName = value; }
        }
        private string ForeName;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDrivedClass myDrivedClass = new MyDrivedClass();
           // MyBaseClass myBase = new MyBaseClass();
            myDrivedClass.foreName = "DDD";
            Console.WriteLine(myDrivedClass.foreName.ToString());
           // Console.WriteLine(myBase);
         
        }
    }
}
