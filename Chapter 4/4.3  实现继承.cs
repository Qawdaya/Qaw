using System;

namespace Chapter_4
{
    class CustomerAccount
    {
        public virtual decimal Calculateprice()
        {
            Console.WriteLine("test1");
            return 0.0M;
        }
    }
    class GoldAccount:CustomerAccount
    {
        public override decimal Calculateprice()
        {
            Console.WriteLine("test");
            return base.Calculateprice() * 0.9M;

        }
      
    }


    class Program
    {
        static void Main(string[] args)
        {
            GoldAccount a=new GoldAccount();
            a.Calculateprice();
            Console.ReadKey();
           
        }
    }
}
