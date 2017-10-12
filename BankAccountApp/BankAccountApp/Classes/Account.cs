using System;
using System.Collections.Generic;
using BankAccountApp.Interfaces;

namespace BankAccountApp
{
    public class Account
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public decimal Balance { get; set; }
		

        public Account()
        {
            
        }

        public void Deposit(decimal amount){
            Balance += amount;
        }

        public void Withdraw(decimal amount){
            Balance -= amount;
        }

        public String GetAccount()
        {
            return $"Account Holder: {Name}, Balance: {Balance}";
        }
    }
}
