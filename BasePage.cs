using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject
{
    [Binding]
    public class BasePage

    {

        public IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
        this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
