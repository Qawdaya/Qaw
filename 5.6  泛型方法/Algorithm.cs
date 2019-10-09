using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
