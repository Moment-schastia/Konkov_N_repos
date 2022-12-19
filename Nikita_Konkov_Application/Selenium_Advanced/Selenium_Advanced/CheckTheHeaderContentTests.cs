using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Selenium_Advanced
{
    [TestFixture]
    public class SCheckTheHeaderContentTeststs // I couldn't think of anything better.
    {
        private IWebDriver _webDriver { get; set; }
        private WebDriverWait _waiter { get; set; }
        private TimeSpan _timeout = TimeSpan.FromSeconds(7);
        private string _mainEpamLink = "https://www.epam.com";
        private string _careersJobListingEpamLink = "https://www.epam.com/careers/job-listings";

        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
        }

        [SetUp]
        public void SetupWaiter()
        {
            _waiter = new WebDriverWait(_webDriver, _timeout);
        }

        [Test]
        public void CheckPageCareerJoblisting()
        {
            _webDriver.Navigate().GoToUrl(_mainEpamLink);

            var careersElement = _webDriver.FindElement(By.XPath("//*[@href='/careers']"));

            Actions _mouseControl = new Actions(_webDriver);
            _mouseControl.MoveToElement(careersElement).Build().Perform();

            _webDriver.FindElement(By.XPath("//*[@href = \"/careers/job-listings\"]")).Click();

            Assert.That(_webDriver.Url, Is.EqualTo(_careersJobListingEpamLink), "You are not at 'Job-listings' site page");
        }

        [Test]
        public void SecondMethod()
        {
            var expectedlocationSelectorList = new List<string> { };

            var action = new Actions(_webDriver);

            _webDriver.Navigate().GoToUrl(_mainEpamLink);

            var buttonGlobalEnaElem = _waiter.Until(_webDriver => _webDriver.FindElement(By.XPath("//*[contains(@class, \"location-selector__button\")]")));
            action.MoveToElement(buttonGlobalEnaElem).Click().Build().Perform();

            var languageList = _waiter.Until(_webDriver => _webDriver.FindElements(By.XPath("//*[@class =\"location-selector__item\"]")));

        }

        [Test]
        public void CheckTheSearchPage()
        {
            _webDriver.Navigate().GoToUrl(_mainEpamLink);
            _webDriver.FindElement(By.XPath("//*[@class = \"header-search__button header__icon\"]")).Click();
            _webDriver.FindElement(By.XPath("//*[@id = \"new_form_search\"]")).SendKeys("Automation");
            _webDriver.FindElement(By.XPath("//*[@class = \"header-search__submit\"]")).Click();

            var action = new Actions(_webDriver);
            //var viewMoreButton = _webDriver.FindElement(By.ClassName("@class=\"search-results__view-more\"]"));
            //action.ScrollToElement(viewMoreButton).Build().Perform();
            var articleList = _webDriver.FindElements(By.XPath("//*[@class = \"search-results__item\"]"));
            Assert.That(articleList.Count(), Is.EqualTo(20), "Unexpected number of result articles");


        }
        

        [TearDown]

        public void End()
        {
            _webDriver.Quit();
        }
    }
}