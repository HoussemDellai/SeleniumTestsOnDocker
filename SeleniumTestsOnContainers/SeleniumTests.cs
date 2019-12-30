using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace SeleniumTestsOnContainers
{
    [TestClass]
    public class SeleniumTests
    {
        private RemoteWebDriver _driver;
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            var options = new ChromeOptions();
            //options.AddArguments("--incognito");
            //options.AddUserProfilePreference("download.default_directory", @"D:\tmp");
            //options.AddUserProfilePreference("download.prompt_for_download", false);
            //options.AddUserProfilePreference("disable-popup-blocking", "true");

            // To run tests on your local machine web driver
            // var driver = new ChromeDriver("../../../chromedriver78/", options);
            var remoteWebDriverUrl = TestContext.Properties["remoteWebDriverUrl"] as string;
            _driver = new RemoteWebDriver(new Uri(remoteWebDriverUrl), options);
        }

        [TestMethod]
        public void PageLive_Test()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.youtube.com/houssemdellai");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            Assert.IsTrue(_driver.PageSource.Contains("Houssem Dellai"));
        }
    }
}
