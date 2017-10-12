using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace pom.example.pages
{
    public class BbcSignInPage
    {
        private IWebDriver driver;

        public BbcSignInPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "username-input")]
        private IWebElement UsernameField;

        [FindsBy(How = How.Id, Using = "password-input")]
        private IWebElement PasswordField;

		[FindsBy(How = How.Id, Using = "submit-button")]
		private IWebElement SubmitButton;

		//[FindsBy(How = How.ClassName, Using = "field-error")]
		//private IWebElement FieldError;

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://account.bbc.com/signin");
        }

        public void EnterUsername(string username)
        {
            UsernameField.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            PasswordField.SendKeys(password);
        }

        public void ClickSubmit()
        {
            SubmitButton.Click();
        }

        public bool fieldError()
        {
            try
            {
                driver.FindElements(By.ClassName("field-error"));

            } catch(NoSuchElementException e){
                
                return false;
            }
            return true;
        }
    }
}
