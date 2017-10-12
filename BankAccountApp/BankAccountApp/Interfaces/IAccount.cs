using System;
using System.Collections.Generic;

namespace BankAccountApp.Interfaces
{
    public interface IAccount
    {
        String GetAccount();
        String GetName();
        void SetName(String name);
        decimal GetBalance();
        void SetBalance(decimal balance);

    }
}
