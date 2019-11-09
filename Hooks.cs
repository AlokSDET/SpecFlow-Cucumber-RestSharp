using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject
{
    [Binding]
    public class Hooks
    {

        public static IWebDriver driver;

        [BeforeFeature]
        public static void SetUp()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [AfterFeature]
        public static void TearDown()
        {
            driver.Quit();
            driver.Dispose();
            driver = null;
        }
    }
}
