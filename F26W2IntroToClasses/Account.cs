using System;
using System.Collections.Generic;
using System.Text;

namespace F26W2IntroToClasses
{
    public class Account
    {
        // prop
        public int MyProperty1 { get; set; }

        // propg
        public int MyProperty { get; private set; }

        // propfull
        private double _balance;

        public double Balance
        {
            get { return _balance; }
            private set { _balance = value; }
        }

        public Account(double balance)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
