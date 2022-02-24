using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace HealthilyProject
{
    public class Tests
    {
        private IWebDriver;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
                       IWebdriver = new ChromeDriver();
                        driver.Manage().Window.Maximize();
                        driver.Navigate().GoToUrl("https://www.livehealthily.com/");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}