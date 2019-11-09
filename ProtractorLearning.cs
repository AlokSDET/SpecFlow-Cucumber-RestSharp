using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject
{
    class ProtractorLearning
    {

        public static NgWebDriver ngWebDriver;
        public static IWebDriver driver;

        [SetUp]
        public void SetUpProtractor()
        {
            driver = new ChromeDriver();

            driver.Url = "http://www.angularjs.org";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            ngWebDriver = new NgWebDriver(driver);
        }


        [Test]
        public void ProtractorTest()
        {
            ngWebDriver.FindElement(NgBy.Model("yourName")).SendKeys("Alok Shrivastava");
            System.Threading.Thread.Sleep(10000);
        }


        [TearDown]
        public void TearDownProtractor()
        {
            driver.Quit();
            driver.Dispose();


        }
    }
}
