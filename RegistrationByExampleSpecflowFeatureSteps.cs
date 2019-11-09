using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowProject
{
    [Binding]
    public class RegistrationByExampleSpecflowFeatureSteps 

    {
        public RegistrationPage rgstrnPage;
        public LoginPage loginPage;
        public IWebDriver driver;

        public RegistrationByExampleSpecflowFeatureSteps()
        {
            this.driver = Hooks.driver;
            this.rgstrnPage = new RegistrationPage(driver);
            this.loginPage = new LoginPage(driver);
        }

        [When(@"Select your type of Buisness as (.*)")]
        public void WhenSelectYourTypeOfBuisnessAsIAmASupplier(string org)
        {

            Thread.Sleep(1000);
            rgstrnPage.SelectOrgType(org);
            
        }
        
        [When(@"Select your type as (.*)")]
        public void WhenSelectYourTypeAs(string buisness)
        {
            rgstrnPage.SelectBuisnessFromDropDown(buisness);
        }
        
        [When(@"Enter your No of personnel as (.*)")]
        public void WhenEnterYourNoOfPersonnelAs(string personnel)
        {
            rgstrnPage.EnterPersonnel(personnel);
        }

        [When(@"Select your annual turnover as (.*)")]
        public void WhenSelectYourAnnualTurnoverAs(string turnover)
        {
            rgstrnPage.SelectAnnualTurnOverFromDropDown(turnover);
        }
        
        [When(@"Select your membership as (.*)")]
        public void WhenSelectYourMembershipAsSilver(string membershipLevel)
        {
            rgstrnPage.SelectMemberShipLevel(membershipLevel);
        }
        
        [When(@"If plan is silver then Add or remove accliam accredition to service (.*)")]
        public void WhenAddAccliamAccreditionToServiceTrue(string acclaimStatus)
        {
            if(rgstrnPage.SilverRadioElement.Selected)
            {
                if (acclaimStatus.ToUpper().Equals("FALSE"))
                {
                    Console.WriteLine("Do nothing");
                }
                else if (acclaimStatus.ToUpper().Equals("TRUE"))
                {
                    rgstrnPage.AddAcclaimStatusTrue();
                }
            }
        }

        [When(@"If plan is gold then choose deemed to satisfy or Acclaim (.*)")]
        public void WhenIfPlanIsGoldThenChooseDeemedToSatisfy(string deemedToSatisfyOrAcclaim)
        {
            if (rgstrnPage.GoldRadioElement.Selected)
            {
                if (deemedToSatisfyOrAcclaim.Equals("Deemed To Satisfy"))
                {
                    Utility.Click(driver, rgstrnPage.DeemedToSatisfyRadioElement);
                }
                else if (deemedToSatisfyOrAcclaim.Equals("Acclaim"))
                {
                    Utility.Click(driver, rgstrnPage.AcclaimRadioElement);
                }
            }
          
        }

    }
}
