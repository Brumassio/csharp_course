using Sessao11.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao11.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number=number;
            Holder=holder;
            Balance=balance;
            WithdrawLimit=withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (WithdrawLimit < amount)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else if (Balance - amount < 0)
            {
                throw new DomainException("Not enough balance");
            }


            Balance -= amount;
        }

        public override string ToString()
        {
            return "Number: "+Number+"\nHolder: "+ Holder+"\nBalance: $ "+Balance.ToString("F2",CultureInfo.InvariantCulture)+"\nWithdrawLimit: $ "+ WithdrawLimit.ToString("F2",CultureInfo.InvariantCulture)+ "\n";
        }
    }
}
