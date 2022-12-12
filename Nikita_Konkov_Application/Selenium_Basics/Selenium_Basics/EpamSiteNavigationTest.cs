using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    [TestFixture]
    public class EpamSiteNavigationTest
    {
        private IWebDriver webDriver = new ChromeDriver();
        private string _epamMainLink;

        [SetUp]
        public void Setup()
        {
            _epamMainLink = "https://www.epam.com/";
        }

        [Test]
        public void CheckNavigationToEpamSite()
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl(_epamMainLink);

            Assert.AreEqual(_epamMainLink, webDriver.Url, "You are not in main epam page!");
        }

        [TearDown]
        public void End()
        {
            webDriver.Quit();
        }
    }
}