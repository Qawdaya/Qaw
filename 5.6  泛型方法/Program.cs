using System;
using System.Collections.Generic;
namespace _5._6__泛型方法
{
   
    class Program
    {
       
        static void Main(string[] args)
        {
            var accounts = new List<Account>()
            {
                new Account("Christan",1500),
                 new Account("Stephanie",2200),
                  new Account("Angela",1800),
                   new Account("Matthias",2400)
            };
            decimal amount = Algorithm.AccumulateSimple(accounts);
             amount = Algorithm.Accumulate(accounts);
            amount = Algorithm.Accumulate<Account, decimal>(accounts, (item, sum) => sum += item.Balance);
            Console.ReadKey();

        }
           
    }
}
