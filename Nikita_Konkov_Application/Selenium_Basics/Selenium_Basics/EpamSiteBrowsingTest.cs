using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    [TestFixture]
    public class EpamSiteBrowsingTest
    {
        private IWebDriver webDriver = new ChromeDriver();
        private string _epamMainLink;
        private string _epamHowWeDoItLink;
        private string _epamOurWorkLink;

        [SetUp]
        public void Setup()
        {
            _epamMainLink = "https://www.epam.com/";
            _epamHowWeDoItLink = "https://www.epam.com/how-we-do-it";
            _epamOurWorkLink = "https://www.epam.com/our-work";
        }

        [Test]
        public void CheckNavigationToEpamSite()
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl(_epamMainLink);

            Assert.AreEqual(_epamMainLink, webDriver.Url, "You are not in main epam page!");
        }

        [Test]
        public void CheckHowWeDoItAndOurWorkNavigation()
        {
            webDriver.Navigate().GoToUrl(_epamHowWeDoItLink);
            webDriver.Navigate().GoToUrl(_epamOurWorkLink);
            webDriver.Navigate().Refresh();
            webDriver.Navigate().Back();

            Assert.AreEqual(_epamHowWeDoItLink, webDriver.Url, "You are not in main epam page!");
        }

        [TearDown]
        public void End()
        {
            webDriver.Quit();
        }
    }
}