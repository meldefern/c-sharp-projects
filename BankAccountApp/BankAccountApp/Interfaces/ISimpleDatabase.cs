using System;
using System.Collections.Generic;

namespace BankAccountApp.Interfaces
{
    public interface ISimpleDatabase
    {
        List<String> GetAll();
    }
}
