using System;
using Wrox.ProCSharp;
using Wrox.ProCSharp.VenusBank;
using Wrox.ProCSharp.JupiterBank;
using Wrox.ProCSharp.ItransferAccount;
namespace Wrox.ProCSharp
{
    class MainEntryPoint
    {
        static void Main()
        {
            IBankAccount venusAccount = new SaverAccount();
            IBankAccount jupiterAccount = new GoldAccount();
            venusAccount.PayIn(200);
            venusAccount.Withdraw(100);
            Console.WriteLine(venusAccount.ToString());
            jupiterAccount.PayIn(500);
            jupiterAccount.Withdraw(600);
            jupiterAccount.Withdraw(100);
            Console.WriteLine(jupiterAccount.ToString());
            ITransferBankAccount Account = new CurrentAccount();
            Account.TransferTo(venusAccount, 100);
            Console.WriteLine(Account.ToString());
        }
    }
}


namespace Wrox.ProCSharp
{
    public interface ITransferBankAccount : IBankAccount
    {
        bool TransferTo(IBankAccount destination, decimal amount);
    }

public interface IBankAccount
    {
        void PayIn(decimal amount);
        bool Withdraw(decimal amount);
        decimal Balance
        {
            get;
        }
    }
}

namespace Wrox.ProCSharp.VenusBank
{
    public class SaverAccount : IBankAccount
    {
        private decimal balance;
        public void PayIn(decimal amount)
        {
            balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            Console.WriteLine("Withdrawal attempt failed.");
            return false;
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
        }
        public override string ToString()
        {
            return String.Format("Venus Bank Saver: Balance = {0,6:C}", balance);
        }
    }
}

namespace Wrox.ProCSharp.JupiterBank
{
    public class GoldAccount : IBankAccount
    {
        private decimal balance;
        public void PayIn(decimal amount)
        {
            balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            Console.WriteLine("Withdrawal attempt failed.");
            return false;
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
        }
        public override string ToString()
        {
            return String.Format("Jupiter Bank Saver: Balance = {0,6:C}", balance);
        }
    }

}

namespace Wrox.ProCSharp.ItransferAccount
{
      public class CurrentAccount : ITransferBankAccount
    {
        private decimal balance;
        public void PayIn(decimal amount)
        {
            balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            Console.WriteLine("Withdrawal attempt failed.");
            return false;
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
        }
        public bool TransferTo(IBankAccount destination, decimal amount)
        {
            bool result;
            if ((result = Withdraw(amount)) == true)
                destination.PayIn(amount);
            return result;
        }
        public override string ToString()
        {
            return String.Format("Jupiter Bank Current Account: Balance = {0,6:C}",
                                                                            balance);
        }

    }

}