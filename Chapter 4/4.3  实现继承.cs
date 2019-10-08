using System;

namespace Chapter_4
{

   
   public sealed class FinalClass
    {
        public void method()
        {
            Console.WriteLine("密封类");
        }

    }
    /*密封类不能作为基类被继承，但它可以继承别的类或接口。
     class DrivedClass:FinalClass
    {

    }*/
    public  class myclassbase
    {
        public virtual void finalmethod()
        {
            Console.WriteLine("基类中的虚方法");
        }
    }
   
    class myclass:myclassbase
    {
        public sealed override void finalmethod()
        {
            base.finalmethod();
            Console.WriteLine("密封中重写后的方法");
        }
    }
    /*并不是每个方法都可以声明为密封方法，密封方法只能用于对基类的虚方法进行实现，并提供具体的实现。
     * 所以，声明密封方法时，sealed 修饰符总是和 override 修饰符同时使用。
     
     * class drivedclass:myclass
    {
        public override void finalmethod()
        {

        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {

            FinalClass finalClass = new FinalClass();
            finalClass.method();
            myclass myclass = new myclass();
            myclass.finalmethod();
              Console.ReadKey();
           
        }
    }
}
