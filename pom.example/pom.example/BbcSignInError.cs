using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using pom.example.pages;
namespace pom.example
{
    [TestFixture()]
    public class BbcSignInError
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test()]
        public void BbcSignInErrorFirst()
        {
            BbcHomepage bbcHompage = new BbcHomepage(driver);
            bbcHompage.GoToPage();
            bbcHompage.ClickSignInLink();
        }

        [Test()]
        public void BbcSignInErrorSecond()
        {
            BbcSignInPage bbcSignInPage = new BbcSignInPage(driver);
            bbcSignInPage.GoToPage();
            bbcSignInPage.EnterUsername("hello@hello.com");
            bbcSignInPage.EnterPassword("12345");
            bbcSignInPage.ClickSubmit();
            Assert.AreEqual(bbcSignInPage.fieldError(), true);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
