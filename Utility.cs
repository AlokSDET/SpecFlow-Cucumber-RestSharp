using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject
{
    class Utility 
    {

        public static void GoToUrl( IWebDriver driver, String url)
        {
            driver.Url = url;
        }

        public static Boolean IsDisplayed(IWebElement webElement)
        {
            return webElement.Displayed;
        }

        public static void Click(IWebDriver driver, IWebElement webElement)
        {
            WaitForElement1(driver, webElement);
            webElement.Click();
        }

        public static void SendKeys(IWebDriver driver, IWebElement webElement, String textToEnter)
        {
            WaitForElement1(driver, webElement);
            webElement.Clear();
            webElement.SendKeys(textToEnter);
        }

        public static void ExplicitWait(IWebDriver driver, By by, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));

        }


        public static void WaitForElement(IWebDriver driver, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           wait.Until<IWebElement>(d => d.FindElement(by));

        }

        public static void WaitForElement1(IWebDriver driver, IWebElement webElement)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until<IWebElement>(d => webElement);
        }


        public static void WaitForElementToBeClickable(IWebDriver driver, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static void SelectFromDropDownByText(IWebElement selectElement, String optionToSelect)
        {
            SelectElement select = new SelectElement(selectElement);
            select.SelectByText(optionToSelect);
        }
    }
}
