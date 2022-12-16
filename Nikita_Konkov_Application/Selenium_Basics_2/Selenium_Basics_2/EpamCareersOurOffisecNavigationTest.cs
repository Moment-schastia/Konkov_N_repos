using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Selenium_Basics_2
{
    public class EpamCareersOurOffisecNavigationTest
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
            webDriver.FindElement(By.XPath("//*[@href =\"/careers\"]")).Click();
            var ourOffices = webDriver.FindElement(By.XPath("//*[@class = 'tabs__ul js-tabs-links-list']"));
            var ourOfficesElementList = ourOffices.FindElements(By.XPath(".//div")); // the second part of task, i have no idea how to do
            Assert.AreEqual("https://www.epam.com/careers", webDriver.Url, "You are not in main epam page!");
        }

        [TearDown]
        public void End()
        {
            webDriver.Quit();
        }
    }
}