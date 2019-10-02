using System;

namespace Chapter_4
{
    public abstract  class test
    {          
        public abstract void TEST();
    }
   
  public  class GoldAccount:test
    {
        public override void TEST()
        {
            Console.WriteLine("test");
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {

            GoldAccount G = new GoldAccount();
            test T = G;
            T.TEST();
            Console.ReadKey();
           
        }
    }
}
