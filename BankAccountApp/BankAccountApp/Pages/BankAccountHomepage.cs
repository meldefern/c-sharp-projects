using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BankAccountApp.Pages
{
    public class BankAccountHomepage
    {
        private IWebDriver driver;

        public BankAccountHomepage(IWebDriver driver)
        {
			this.driver = driver;
			//PageFactory.InitElements(driver, this);
		}

        [FindsBy(How = How.LinkText, Using = "Withdraw/Deposit")]
        private IWebElement WithdrawDepositLink;

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("localhost:5001/");
        }

        public void ClickWithdrawDeposit()
        {
            WithdrawDepositLink.Click();
        }
    }
}