using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Basics
{
    [TestFixture]
    public class EpamHowWeDoItOurWorkNavigationTest
    {
        private IWebDriver webDriver = new ChromeDriver();
        private string _epamHowWeDoItLink;
        private string _epamOurWorkLink;

        [SetUp]
        public void Setup()
        {
            _epamHowWeDoItLink = "https://www.epam.com/how-we-do-it";
            _epamOurWorkLink = "https://www.epam.com/our-work";
        }

        [Test]
        public void CheckHowWeDoItAndOurWorkNavigation()
        {
            webDriver.Manage().Window.Maximize();
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
