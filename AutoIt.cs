using AutoIt;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject
{
    class AutoIt
    {

        IWebDriver driver;

        [Test]
        public void FileUpload()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://softwaretestingplace.blogspot.com/2015/10/sample-web-page-to-test.html";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // File uploading by direct send keys when we are passing file path
            //  driver.FindElement(By.XPath("//input[@name='uploadfile']")).SendKeys(@"C:\Users\P10484475\Desktop\AutoItFileUpload.txt");


            // File uploading by AutoIT 
            IWebElement element = driver.FindElement(By.XPath("//input[@name='uploadfile']"));

            AutoItX.WinWaitActive("Open");



            AutoItX.Send(@"C:\Users\P10484475\Desktop\AutoItFileUpload.txt");
            AutoItX.Send("{ENTER}");
        }
    }
}
