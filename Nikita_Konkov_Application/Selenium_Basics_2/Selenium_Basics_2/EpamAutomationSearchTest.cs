using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Basics_2
{
    public class EpamAutomationSearchTest
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
            webDriver.FindElement(By.XPath("//*[@class = \"header-search__button header__icon\"]")).Click();
            webDriver.FindElement(By.XPath("//*[@id = \"new_form_search\"]")).SendKeys("Automation");
            webDriver.FindElement(By.XPath("//*[@class = \"header-search__submit\"]")).Click();
            Assert.AreEqual("https://www.epam.com/search?q=Automation", webDriver.Url, "You are not in Automation search page!");
        }

        [TearDown]
        public void End()
        {
            webDriver.Quit();
        }
    }
}
