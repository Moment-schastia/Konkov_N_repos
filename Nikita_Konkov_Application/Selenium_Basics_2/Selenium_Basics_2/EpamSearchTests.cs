using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using System.Security.Cryptography.X509Certificates;

namespace Selenium_Basics_2
{
    public class EpamSearchTests
    {
        private IWebDriver _webDriver { get; set; }
        private string _epamMainLink = "https://www.epam.com/";
        private string _epamSearchResultAutomation = "https://www.epam.com/search?q=Automation";
        private string _epamSearchResultBusinAnalys = "https://www.epam.com/search?q=Business+Analysis";

        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
        }


        [TestCase("Automation")]
        public void CheckAutomationSearchResult(string wordToSearch)
        {
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(_epamMainLink);
            _webDriver.FindElement(By.XPath("//*[@class = \"header-search__button header__icon\"]")).Click();
            _webDriver.FindElement(By.XPath("//*[@id = \"new_form_search\"]")).SendKeys(wordToSearch);
            _webDriver.FindElement(By.XPath("//*[@class = \"header-search__submit\"]")).Click();
            Assert.AreEqual(_epamSearchResultAutomation, _webDriver.Url, "You are not in Automation search page!");

            var automatinResultList = _webDriver.FindElements(By.XPath("//*[@class=\"search-results__item\"]")).Take(5);
            var sortedResultList = automatinResultList.Where(l => l.Text.Contains(wordToSearch)).ToList();// регистра чувствительность, либо ту ловер 
            Assert.AreEqual(automatinResultList, sortedResultList, "The search results are not correct");
        }

        [TestCase("Business Analysis")]
        public void CheckBusinesAnalisResult(string wordToSearch)
        {
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(_epamMainLink);
            _webDriver.FindElement(By.XPath("//*[@class = \"header-search__button header__icon\"]")).Click();
            _webDriver.FindElement(By.XPath("//*[@id = \"new_form_search\"]")).SendKeys(wordToSearch);
            _webDriver.FindElement(By.XPath("//*[@class = \"header-search__submit\"]")).Click();
            Assert.AreEqual(_epamSearchResultBusinAnalys, _webDriver.Url, "You are not in Automation search page!");

            var firstSearchResult = _webDriver.FindElement(By.XPath("//*[@class = 'search-results__item']//a"));

            firstSearchResult.Click();
            var firstResulrPage= _webDriver.FindElement(By.XPath("//*[contains(@class, 'title-ui title--center')]"));
            Assert.AreEqual(firstSearchResult.Text, firstResulrPage.Text, "Title of first result is not equal to its page title");
        }// закрыть куки 

        [TearDown]
        public void End()
        {
            _webDriver.Quit();
        }
    }
}
