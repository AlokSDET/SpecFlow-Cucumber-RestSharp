using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject
{

    public class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//h1[text()='Sign up for Constructionline']")]
        public IWebElement HeadingSignUpForCLine { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'What type of business are you?')]/following::select[1]")]
        public IWebElement BuisnessSelectOption { get; set; }


        [FindsBy(How = How.XPath, Using = "//h2[text()='Plan Selection']")]
        public IWebElement HeadingPlanSelection { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='How many personnel do you have in total']/following::input[1]")]
        public IWebElement PersonnelTextElement { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Please select your businesses annual turnover range']/following::select")]
        public IWebElement AnnualTurnOverSelectOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[text()='Silver']/preceding-sibling::input")]
        public IWebElement SilverRadioElement { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[text()='Gold']/preceding-sibling::input")]
        public IWebElement GoldRadioElement { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@name='acclaim']")]
        public IWebElement AddAcclaimStatusCheckBoxElement { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Acclaim']/preceding-sibling::input")]
        public IWebElement AcclaimRadioElement { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Deemed To Satisfy']/preceding-sibling::input")]
        public IWebElement DeemedToSatisfyRadioElement { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[text()='Your Details']")]
        public IWebElement YourDetailsPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()[normalize-space()='Your Details']][1]/child::i")]
        public IWebElement YourDetailsLink { get; set; }


        public IWebElement OrgTypeElement(String org)
        {
            return driver.FindElement(By.XPath("//span[text()[normalize-space() = '" + org.Trim() + "']]/input"));
        }

        public IWebElement MemberShipLevelElement(String memberShipLevel)
        {
            return driver.FindElement(By.XPath("//label[text()='" + memberShipLevel + "']/preceding-sibling::input"));
        }

        public void SelectMemberShipLevel(String memberShipLevel)
        {
            Utility.Click(driver, MemberShipLevelElement(memberShipLevel));

        }

        public void AddAcclaimStatusTrue()
        {
            Utility.Click(driver, AddAcclaimStatusCheckBoxElement);

        }


        public void SelectOrgType(String org)
        {
            Utility.Click(driver, OrgTypeElement(org));
        }

        public void SelectBuisnessFromDropDown(String buisness)
        {
            Utility.SelectFromDropDownByText(BuisnessSelectOption, buisness);
        }

        public void SelectAnnualTurnOverFromDropDown(String annualTurnOver)
        {
            Utility.SelectFromDropDownByText(AnnualTurnOverSelectOption, annualTurnOver);
        }

        public void EnterPersonnel(String personnel)
        {
            Utility.SendKeys(driver, PersonnelTextElement, personnel);
        }
    }
}
