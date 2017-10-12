using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BankAccountApp.Pages;

namespace BankAccountApp.Tests
{
    [TestFixture()]
    public class DepositMoneyInAccount
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test()]
        public void DepositMoney()
        {
            BankAccountHomepage bankAcountHomepage = new BankAccountHomepage(driver);
            bankAcountHomepage.GoToPage();
            bankAcountHomepage.ClickWithdrawDeposit();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
