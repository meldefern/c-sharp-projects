using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankAccountApp.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankAccountApp.Controllers
{
    public class WithdrawDepositController : Controller
    {
        // GET: /<controller>/
        public IActionResult GetForm()
        {
            
            return View();
        }

         //POST: /
        [HttpPost]
        public IActionResult Confirmation()
        {
			string amount = HttpContext.Request.Form["amount"];
            string withdrawOrDeposit = HttpContext.Request.Form["transaction"];

            TempData["amount"] = amount;
            TempData["choice"] = withdrawOrDeposit;
			
			return View();
        }

    }
}
