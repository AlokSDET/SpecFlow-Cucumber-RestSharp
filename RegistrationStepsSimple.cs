
using Dynamitey.DynamicObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject
{
    [Binding]
    public class RegistrationStepsSimple 
    {

        public RegistrationPage rgstrnPage;
        public LoginPage loginPage;
        public IWebDriver driver;

        public RegistrationStepsSimple()
        {
           
            this.driver = Hooks.driver;
            this.rgstrnPage = new RegistrationPage(driver);
            this.loginPage = new LoginPage(driver);
        }

        [Given(@"Construction online home page is launched")]
        public void GivenConstructionOnlineHomePageIsLaunched()
        {

            Utility.GoToUrl(driver, "https://conslsitwebapp.azurewebsites.net/mmp/#/authenticate");
            Assert.True(Utility.IsDisplayed(loginPage.LogInBtn));
        }

        [Given(@"Register Now link is being displayed")]
        public void GivenRegisterNowLinkIsBeingDisplayed()
        {
            Assert.True(Utility.IsDisplayed(loginPage.RegistNowLink));
        }

        [When(@"Click on Register now link")]
        public void WhenClickOnRegisterNowLink()
        {
            loginPage.ClickOnRegisterNowLink();
        }

        [Then(@"Verify that it takes to the sign up for contruction page")]
        public void ThenVerifyThatItTakesToTheSignUpForContructionPage()
        {
            Assert.True(rgstrnPage.HeadingSignUpForCLine.Displayed, "Sign up page is not loaded correctly");
        }

        [When(@"Plan selection page is displayed")]
        public void WhenPlanSelectionPageIsDisplayed()
        {
            Assert.True(rgstrnPage.HeadingPlanSelection.Displayed, "Plan Selection page is not loaded correctly");
        }

        [When(@"Select your type of organization as (.*)")]
        public void WhenSelectYourTypeOfOrganizationAs(string org)
        {
            rgstrnPage.SelectOrgType(org);
        }

        [When(@"Select your buisness as ""(.*)""")]
        public void WhenSelectYourBuisness(string business)
        {
            rgstrnPage.SelectBuisnessFromDropDown(business);

        }

        [When(@"Enter your personnel as ""(.*)""")]
        public void WhenEnterYourPersonnel(String personnel)
        {
            rgstrnPage.EnterPersonnel(personnel);
        }

        [When(@"Select your buisness annual turnover as ""(.*)""")]
        public void WhenSelectYourBuisnessAnnualTurnover(string turnover)
        {
            rgstrnPage.SelectAnnualTurnOverFromDropDown(turnover);
        }


        [When(@"Select your membership level as ""(.*)""")]
        public void WhenSelectYourPlanAs(string membershipLevel)
        {
            rgstrnPage.SelectMemberShipLevel(membershipLevel);
        }


        [When(@"Add accliam to service ""(.*)""")]
        public void WhenAddAccliamToServiceAs(string acclaimStatus)
        {
            if (rgstrnPage.SilverRadioElement.Selected)
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


        [When(@"Click on your details link")]
        public void WhenClickOnYourDetailsLink()
        {
            Utility.Click(driver, rgstrnPage.YourDetailsLink);
        }

        [Then(@"Verify that your details page is being displayed")]
        public void ThenVerifyThatYourDetailsPageIsBeingDisplayed()
        {
            Assert.True(rgstrnPage.YourDetailsPage.Displayed);
        }

        [When(@"fill below information by Dictionary")]
        public void WhenFillBelowInformation(Table table)
        {
            //Converting table in to Data Table
            var dictionary = new Dictionary<string, string>();
            foreach(var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            var userName = dictionary["UserName"];
            var password = dictionary["Password"];
            Console.WriteLine(userName);
            Console.Write(password);
        }


        [When(@"fill below information by CreateSet")]
        public void WhenFillBelowInformationByDataTable(Table table)
        {
            var credentials = table.CreateSet<Credentials>();
            foreach(var userData in credentials)
            {
                Console.WriteLine(userData.UserName);
                Console.WriteLine(userData.Password);
            }
        }


        [When(@"fill below information by CreateInstance")]
        public void WhenFillBelowInformationByCreateInstance(Table table)
        {
           var credentials =  table.CreateInstance<Credentials>();
                var userName = credentials.UserName;
                var password = credentials.Password;
            
        }

        [When(@"fill below information by DynamicSet")]
        public void WhenFillBelowInformationByDynamicSet(Table table)
        {
           IEnumerable<dynamic> credentials =  table.CreateDynamicSet();
            foreach( var credential in credentials)
            {
               var userName =  credential.UserName;
               var password = credential.Password;
            }
        }

    }
}
