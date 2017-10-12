using System;
namespace BankAccountApp.Controllers
{
    public class AccountController
    {
        String Name;
        decimal balance = 100;
        protected double Balance { get{
                return balance;
            } set{
                balance = value;
            }
        }

        public AccountController()
        {
        }




    }
}
