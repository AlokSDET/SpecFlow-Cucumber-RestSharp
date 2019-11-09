using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject
{
   public class LoginPage :BasePage
    {

        public LoginPage(IWebDriver driver):base(driver)
        {
     
        }
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Log in')]")]
        public IWebElement LogInBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='signup']")]
        public IWebElement RegistNowLink { get; set; }

        public void ClickOnRegisterNowLink()
        {
            Utility.Click(driver, RegistNowLink);
        }
    }
}
