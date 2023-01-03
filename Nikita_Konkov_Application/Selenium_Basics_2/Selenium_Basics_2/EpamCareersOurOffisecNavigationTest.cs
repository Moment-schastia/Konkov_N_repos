using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework.Constraints;

namespace Selenium_Basics_2
{
    public class EpamCareersOurOffisecNavigationTest
    {
        private IWebDriver _webDriver { get; set; }
        private string _epamMainLink = "https://www.epam.com/";
        private string _careerLInk = "https://www.epam.com/careers";
        private List<string> _expectedOurOfficesList;

        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            _expectedOurOfficesList = new List<string> { "AMERICAS", "EMEA", "APAC" };
        }

        [Test]
        public void CheckOurOfficesCareerPageSite()
        {
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(_epamMainLink);
            _webDriver.FindElement(By.XPath("//*[@href =\"/careers\"]")).Click();
            var ourOffices = _webDriver.FindElement(By.XPath("//*[@class = 'tabs__ul js-tabs-links-list']"));
            var ourOfficesElementList = ourOffices.FindElements(By.XPath(".//div")).ToList();

            Assert.AreEqual(_careerLInk, _webDriver.Url, "You are not in main epam page!");

            var realOfficeListText = ourOfficesElementList.Where(l => l.Text.Equals(_expectedOurOfficesList.Any()));

            Assert.AreEqual(_expectedOurOfficesList, realOfficeListText, "Unexpected Offises' list");
            
        }   

        [TearDown]
        public void End()
        {
            _webDriver.Quit();
        }
    }
}