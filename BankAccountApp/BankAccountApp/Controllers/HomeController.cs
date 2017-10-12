using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccountApp.Models;
using BankAccountApp.Interfaces;
using BankAccountApp.Data;

namespace BankAccountApp.Controllers
{
    public class HomeController : Controller
    {
		BankContext db;

        public HomeController(BankContext context){
            db = context;
        }

		public IActionResult Index([FromServices] ISimpleDatabase database)
        {
            Account acc = new Account { Name = "Melinda", Balance = 100 };
            db.Accounts.Add(acc);
            var count = db.SaveChanges();
            Console.WriteLine($"{count} records saved to database");

            ViewBag.Accounts = db.Accounts;

            ViewData["data"] = database.GetAll();
            ViewData["account"] = acc.GetAccount();

            string choice = (string)TempData["choice"];
            decimal amount = Convert.ToInt32(TempData["amount"]);
            decimal balance = acc.Balance;

            if (choice == "withdrawn")
            {
                if (balance >= amount)
                {
                    acc.Withdraw(amount);
                }
            } else if (choice == "deposited") {
                
                acc.Deposit(amount);

            }

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
