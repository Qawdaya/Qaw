using System;

namespace Chapter_3
{
    public class monkey
    {
        private decimal amount;
        public decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
           
        }
        public override string ToString()
        {
            return "$"+Amount.ToString();
        }
    }
  
    class Program
    {
   
        static void Main(string[] args)
        {
            monkey cash1 = new monkey();
            cash1.Amount = 40M;
            Console.WriteLine("cash1.tostring() returns:" + cash1.ToString());
            Console.ReadLine();


        }

    }

}




