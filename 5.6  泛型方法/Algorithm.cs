using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _5._6__泛型方法
{
    public static  class Algorithm
    {
        public static decimal AccumulateSimple(IEnumerable<Account> source)
        {
            decimal sum = 0;
            foreach(Account a in source)
            {
                sum += a.Balance;
            }
            return sum;
        }
        public static decimal Accumulate<TAccount>(IEnumerable<TAccount>soure)
        where TAccount:IAcount
        {
            decimal sum = 0;
            foreach(TAccount a in soure)
            {
                sum += a.Balance;
            }
            return sum;
        }
    }
}
