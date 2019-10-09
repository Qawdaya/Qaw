using System;
using System.Collections.Generic;
using System.Text;

namespace _5._6__泛型方法
{
   public class Account:IAcount
    {
        public string Name { get; private set; }
        public decimal Balance { get; private set; }
        public Account(string name,decimal balance)
        {
            this.Name = name;
            this.Balance = balance;
        }

    }
}
