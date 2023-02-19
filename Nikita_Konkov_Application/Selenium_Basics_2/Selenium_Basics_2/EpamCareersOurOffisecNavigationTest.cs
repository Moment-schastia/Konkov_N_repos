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

        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
        }

        [Test]
        public void CheckOurOfficesCareerPageSite()
        {
            List<string> expectedOurOfficesList = new List<string> { "AMERICAS", "EMEA", "APAC" };

            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(_epamMainLink);
            _webDriver.FindElement(By.XPath("//*[@href =\"/careers\"]")).Click();
            Assert.AreEqual(_careerLInk, _webDriver.Url, "You are not in main epam page!");

            var ourOffices = _webDriver.FindElement(By.XPath("//*[@class = 'tabs__ul js-tabs-links-list']"));
            var ourOfficesElementList = ourOffices.FindElements(By.XPath(".//div")).ToList();

            var officeListText = ourOfficesElementList.Where(l => l = l.Text.);
            
            Assert.AreEqual(expectedOurOfficesList, officeListText, "Unexpected Offises' list");// через линк отобрать текст в списке эелементов и получившийся список сравнить с ожидаемым списком  
        }   

        [TearDown]
        public void End()
        {
            _webDriver.Quit();
        }
    }
}